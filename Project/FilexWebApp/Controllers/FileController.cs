using FilexWebApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Services;


namespace FilexWebApp.Controllers
{

    public class FileController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage UploadFile()
        {
            string Fname = "";
            if (HttpContext.Current.Request.Files.Count > 0)
            {
                try
                {
                    foreach (var fileName in HttpContext.Current.Request.Files.AllKeys)
                    {
                        HttpPostedFile file = HttpContext.Current.Request.Files[fileName];
                        if (file != null)
                        {

                            FileDTO fileDTO = new FileDTO();

                            fileDTO.FileActualName = Path.GetFileNameWithoutExtension(file.FileName);
                            fileDTO.SourceFileExt = Path.GetExtension(file.FileName);
                            fileDTO.DestinationFileExt = HttpContext.Current.Request["DestinationFileExt"];

                            fileDTO.SourceContentType = file.ContentType;

                            //Generate a unique name using Guid
                            Fname = fileDTO.FileUniqueName = Guid.NewGuid().ToString();

                            //Get physical path of our folder where we want to save images
                            var UploadPath = HttpContext.Current.Server.MapPath("~/UploadedFiles");
                            var DownloadPath = HttpContext.Current.Server.MapPath("~/DownloadedFiles");

                            var fileSavePath = System.IO.Path.Combine(UploadPath, fileDTO.FileUniqueName + fileDTO.SourceFileExt);

                            // Save the uploaded file to "UploadedFiles" folder
                            file.SaveAs(fileSavePath);

                            //Save File Meta data in Database

                            FileDAL.SaveFileInDB(fileDTO);

                            fileDTO.DestinationContentType = DevLib.Convert(UploadPath, DownloadPath, fileDTO.FileUniqueName, fileDTO.SourceFileExt, fileDTO.DestinationFileExt);

                            File.Delete(fileSavePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                return Request.CreateResponse(HttpStatusCode.OK, Fname);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpGet]
        public Object DownloadFile(String uniqueName)
        {
            //Physical Path of Root Folder
            var DownloadPath = System.Web.HttpContext.Current.Server.MapPath("~/DownloadedFiles");

            //Find File from DB against unique name
            var fileDTO = FileDAL.GetFileByUniqueID(uniqueName);
            try
            {
                if (fileDTO != null)
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                    var fileFullPath = System.IO.Path.Combine(DownloadPath, fileDTO.FileUniqueName + fileDTO.DestinationFileExt);

                    byte[] file = System.IO.File.ReadAllBytes(fileFullPath);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(file);

                    response.Content = new ByteArrayContent(file);
                    response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                    //String mimeType = MimeType.GetMimeType(file); //You may do your hard coding here based on file extension

                    response.Content.Headers.ContentType = new MediaTypeHeaderValue(fileDTO.DestinationContentType);// obj.DocumentName.Substring(obj.DocumentName.LastIndexOf(".") + 1, 3);
                    response.Content.Headers.ContentDisposition.FileName = fileDTO.FileActualName + fileDTO.DestinationFileExt;
                    File.Delete(fileFullPath);
                    return response;
                }
                else
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
                    return response;
                }
            }
            catch(Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                return response;
            }
        }
    }
}
