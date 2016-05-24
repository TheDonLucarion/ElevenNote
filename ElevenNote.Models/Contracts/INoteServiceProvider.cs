using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models.Contracts
{
    public interface INoteServiceProvider
    {
        // Authorization
        string Login(string username, string password);

        // CRUD
        bool Create(string userSessionKey, NoteEditViewModel model);
        bool Update(string userSessionKey, NoteEditViewModel model);
        bool Delete(string userSessionKey, int noteId);
        NoteEditViewModel Get(string userSessionKey, int noteId);
        List<NoteListItemViewModel> GetAll(string userSessionKey);
    }
}
