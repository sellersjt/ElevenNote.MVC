using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ElevenNote.Models
{
    public class CreateNoteViewModel
    {
        // Drop down Categories
        public IEnumerable<SelectListItem> Categories { get; set; }

        // Selected Category
        public int CategoryId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Title { get; set; }

        [Required]
        [MaxLength(8000)]
        public string Content { get; set; }
    }
}
