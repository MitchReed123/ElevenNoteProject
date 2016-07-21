using ElevenNote.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.web.Controllers
{
    [Authorize]
    public class NotesController : Controller
    {
        // GET: Notes
        public ActionResult Index()
        {
            var notes =
                new NoteService()
                .GetNotes();
                

            return View(notes);
        }
    }
}