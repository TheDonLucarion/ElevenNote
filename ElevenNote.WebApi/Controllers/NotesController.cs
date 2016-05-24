using ElevenNote.Models;
using ElevenNote.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace ElevenNote.WebApi.Controllers
{
    [Authorize]
    public class NotesController : ApiController
    {
        private Guid CurrentUserId() => new Guid(User.Identity.GetUserId());
        [HttpPost]
        [ActionName("Create")]
        public bool Create(NoteCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var service = new NoteService(CurrentUserId());
                return service.CreateNote(model);
            }

            return false;
        }
        [HttpPatch]
        [ActionName("Update")]
        public bool Update(NoteEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var service = new NoteService(CurrentUserId());
                return service.UpdateNote(model);
            }

            return false;
        }
        [HttpDelete]
        [ActionName("Delete")]
        public bool Delete(int noteId)
        {
            if (ModelState.IsValid) return false;
            {
                var service = new NoteService(CurrentUserId());
                return service.DeleteNote(noteId);
            }
        }
        [HttpGet]
        [ActionName("Get")]
        public NoteDetailViewModel Get(int noteId)
        {
            if (noteId < 1) return null;
            {
                var service = new NoteService(CurrentUserId());
                return service.GetNoteById(noteId);
            }
        }
        [HttpGet]
        [ActionName("GetAll")]
        public IEnumerable<NoteListItemViewModel> GetAll()
        {
            var service = new NoteService(CurrentUserId());
            return service.GetNotes();
        }
    }
}