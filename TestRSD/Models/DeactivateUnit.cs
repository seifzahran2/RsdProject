using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RsdProject.Models
{
    public class DeactivateUnit
    {
        public int id { get; set; }
        [Required]
        public string TReson { get; set; }

        public string Explain{ get; set; }
             
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
