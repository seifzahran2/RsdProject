using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RsdProject.Models
{
    public class DrugSell
    {
        public int id { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال رقم الوصفه")]
        public int WasfaNum { get; set; }
       
        public string TypeSall { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال تاريخ")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال هويه الدكتور")]
        public string Doctor { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال هويه اللامريض")]
        public string Pationat { get; set; }
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
        public DateTime Date2 { get; set; }
    }
}
