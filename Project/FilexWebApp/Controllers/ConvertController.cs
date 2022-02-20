using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilexWebApp.Controllers
{
    public class ConvertController : Controller
    {
        // GET: Convert
        public ActionResult  Index()
        {
            return this.RedirectToAction("Index", "tools");

        }
        public ActionResult Docxtopdf()
        {
            ViewBag.img = "https://img.icons8.com/color/48/000000/word.png";
            ViewBag.H2Title = "DOCX to PDF";
            ViewBag.Disc = "Select a Microsoft Word (.docx) to convert to Pdf.";
            ViewBag.Destination = ".pdf";
            ViewBag.acceptext = ".docx";
            return View("Universal");
        }
        public ActionResult Docxtotext()
        {
            ViewBag.img = "https://img.icons8.com/color/48/000000/word.png";
            ViewBag.H2Title = "DOCX to TXT";
            ViewBag.Disc = "Select a Microsoft Word (.docx) to convert to Text.";
            ViewBag.Destination = ".txt";
            ViewBag.acceptext = ".docx";

            return View("Universal");
        }
        public ActionResult Docxtortf()
        {
            ViewBag.img = "https://img.icons8.com/color/48/000000/word.png";
            ViewBag.H2Title = "DOCX to RTF";
            ViewBag.Disc = "Select a Microsoft Word (.docx) to convert to Rtf.";
            ViewBag.Destination = ".rtf";
            ViewBag.acceptext = ".docx";

            return View("Universal");
        }
        public ActionResult Docxtohtml()
        {
            ViewBag.img = "https://img.icons8.com/color/48/000000/word.png";
            ViewBag.H2Title = "DOCX to HTML";
            ViewBag.Disc = "Select a Microsoft Word (.docx) to convert to Html.";
            ViewBag.Destination = ".html";
            ViewBag.acceptext = ".docx";

            return View("Universal");
        }


        public ActionResult Pdftodocx()
        {
            ViewBag.img = "https://img.icons8.com/color/48/000000/pdf.png";
            ViewBag.H2Title = "Pdf to Docx";
            ViewBag.Disc = "Select a Portable Document File (.pdf) to convert to Docx.";
            ViewBag.Destination = ".docx";
            ViewBag.acceptext = ".pdf";

            return View("Universal");
        }
        public ActionResult Pdftotext()
        {
            ViewBag.img = "https://img.icons8.com/color/48/000000/pdf.png";
            ViewBag.H2Title = "Pdf to Text";
            ViewBag.Disc = "Select a Portable Document File (.pdf) to convert to Text.";
            ViewBag.Destination = ".txt";
            ViewBag.acceptext = ".pdf";
            return View("Universal");
        }
        public ActionResult Pdftohtml()
        {
            ViewBag.img = "https://img.icons8.com/color/48/000000/pdf.png";
            ViewBag.H2Title = "Pdf to Html";
            ViewBag.Disc = "Select a Portable Document File (.pdf) to convert to Html.";
            ViewBag.acceptext = ".pdf";
            ViewBag.Destination = ".html";
            return View("Universal");
        }
        public ActionResult Pdftortf()
        {
            ViewBag.img = "https://img.icons8.com/color/40/000000/pdf.png";
            ViewBag.H2Title = "Pdf to Rtf";
            ViewBag.Disc = "Select a Portable Document File (.pdf) to convert to Rtf.";
            ViewBag.Destination = ".rtf";
            ViewBag.acceptext = ".pdf";

            return View("Universal");
        }
        public ActionResult Texttortf()
        {
            ViewBag.img = "https://img.icons8.com/office/40/000000/txt.png";
            ViewBag.H2Title = "Text to Rtf";
            ViewBag.Disc = "Select a Text File (.txt) to convert to Rtf.";
            ViewBag.Destination = ".rtf";
            ViewBag.acceptext = ".txt";

            return View("Universal");
        }
        public ActionResult Texttohtml()
        {
            ViewBag.img = "https://img.icons8.com/office/40/000000/txt.png";
            ViewBag.H2Title = "Text to Html";
            ViewBag.Disc = "Select a Text File (.txt) to convert to Html.";
            ViewBag.Destination = ".html";
            ViewBag.acceptext = ".txt";

            return View("Universal");
        }
        public ActionResult Texttopdf()
        {
            ViewBag.img = "https://img.icons8.com/office/40/000000/txt.png";
            ViewBag.H2Title = "Text to Pdf";
            ViewBag.Disc = "Select a Text File (.txt) to convert to Pdf.";
            ViewBag.Destination = ".pdf";
            ViewBag.acceptext = ".txt";

            return View("Universal");
        }
        public ActionResult Texttodocx()
        {
            ViewBag.img = "https://img.icons8.com/office/40/000000/txt.png";
            ViewBag.H2Title = "Text to Docx";
            ViewBag.Disc = "Select a Text File (.txt) to convert to Docx.";
            ViewBag.Destination = ".docx";
            ViewBag.acceptext = ".txt";

            return View("Universal");
        }
        public ActionResult Htmltodocx()
        {
            ViewBag.img = "https://img.icons8.com/color/40/000000/code-file.png";
            ViewBag.H2Title = "Html to Docx";
            ViewBag.Disc = "Select a Hypertext Markup Language File (.html) to convert to Docx.";
            ViewBag.Destination = ".docx";
            ViewBag.acceptext = ".html";

            return View("Universal");
        }
        public ActionResult Htmltopdf()
        {
            ViewBag.img = "https://img.icons8.com/color/40/000000/code-file.png";
            ViewBag.H2Title = "Html to Pdf";
            ViewBag.Disc = "Select a Hypertext Markup Language File (.html) to convert to Pdf.";
            ViewBag.Destination = ".pdf";
            ViewBag.acceptext = ".html";

            return View("Universal");
        }
        public ActionResult Htmltotext()
        {
            ViewBag.img = "https://img.icons8.com/color/40/000000/code-file.png";
            ViewBag.H2Title = "Html to Text";
            ViewBag.Disc = "Select a Hypertext Markup Language File (.html) to convert to Text.";
            ViewBag.Destination = ".txt";
            ViewBag.acceptext = ".html";

            return View("Universal");
        }
        public ActionResult Htmltortf()
        {
            ViewBag.img = "https://img.icons8.com/color/40/000000/code-file.png";
            ViewBag.H2Title = "Html to Rtf";
            ViewBag.Disc = "Select a Hypertext Markup Language File (.html) to convert to Rtf.";
            ViewBag.Destination = ".rtf";
            ViewBag.acceptext = ".html";

            return View("Universal");
        }
        public ActionResult Rtftodocx()
        {
            ViewBag.img = "https://img.icons8.com/external-prettycons-flat-prettycons/47/000000/external-file-file-types-prettycons-flat-prettycons-26.png";
            ViewBag.H2Title = "RTF to Docx";
            ViewBag.Disc = "Select a Rich Text File(.rtf) to convert to Docx.";
            ViewBag.Destination = ".docx";
            ViewBag.acceptext = ".rtf";

            return View("Universal");
        }
        public ActionResult Rtftopdf()
        {
            ViewBag.img = "https://img.icons8.com/external-prettycons-flat-prettycons/47/000000/external-file-file-types-prettycons-flat-prettycons-26.png";
            ViewBag.H2Title = "RTF to Pdf";
            ViewBag.Disc = "Select a Rich Text File(.rtf) to convert to Pdf.";
            ViewBag.Destination = ".pdf";
            ViewBag.acceptext = ".rtf";

            return View("Universal");
        }
        public ActionResult Rtftotext()
        {
            ViewBag.img = "https://img.icons8.com/external-prettycons-flat-prettycons/47/000000/external-file-file-types-prettycons-flat-prettycons-26.png";
            ViewBag.H2Title = "RTF to Text";
            ViewBag.Disc = "Select a Rich Text File(.rtf) to convert to Text.";
            ViewBag.Destination = ".txt";
            ViewBag.acceptext = ".rtf";

            return View("Universal");
        }
        public ActionResult Rtftohtml()
        {
            ViewBag.img = "https://img.icons8.com/external-prettycons-flat-prettycons/47/000000/external-file-file-types-prettycons-flat-prettycons-26.png";
            ViewBag.H2Title = "RTF to Html";
            ViewBag.Disc = "Select a Rich Text File(.rtf) to convert to Html.";
            ViewBag.Destination = ".html";
            ViewBag.acceptext = ".rtf";

            return View("Universal");
        }
    }
}