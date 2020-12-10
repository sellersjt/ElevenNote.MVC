using ElevenNote.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteListItem
    {
        [Display(Name = "Note Id")]
        public int NoteId { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }

        [UIHint("Starred")]
        [Display(Name = "Important")]
        public bool IsStarred { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
