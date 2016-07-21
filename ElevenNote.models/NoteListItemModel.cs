using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.models
{
    public class NoteListItemModel
    {

        public int NoteId { get; set; }

        public string Title { get; set; }
        [Display(Name = "DisplayCreated")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString()
        {
            return $"[{NoteId}] {Title}";
        }

    }
}
