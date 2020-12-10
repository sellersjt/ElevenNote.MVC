using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryDetail
    {
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
