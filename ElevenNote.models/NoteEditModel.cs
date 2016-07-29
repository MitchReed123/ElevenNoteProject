using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.models
{
    public class NoteEditModel
    {
        [Required]
        [MinLength(2 , ErrorMessage ="Please enter at least 2 characters")]
        [MaxLength(128)]

        public int NoteId { get; set; }

        [Required]
        [MaxLength(8000)]

        public string Title { get; set; }

        public string Content { get; set; }
        [UIHint("Starred")]
        public bool IsStarred { get; set; }

        public override string ToString()
        {
            return $"[{NoteId}] {Title}";
        }
    }
}
