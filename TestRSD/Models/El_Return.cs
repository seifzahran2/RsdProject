using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RsdProject.Models
{
    public class El_Return
    {
        
        public int Id { get; set; }
        [Required]
        public string GlobalNum { get; set; }
        public string Attach { get; set; }
        [Required]
        public string Datamatrex { get; set; }
        [Required]
        public int NumBand { get; set; }
        [Required]
        public int NumTaslsl { get; set; }
        [Required]
        public int NumDofaa { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
