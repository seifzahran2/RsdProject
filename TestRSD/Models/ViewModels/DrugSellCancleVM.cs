using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RsdProject.Models.ViewModel
{
    public class DrugSellCancleVM
    {
        [Required]
        public string GlobalNum { get; set; }
        public string TypeSall { get; set; }
        public int WasfaNum { get; set; }
        public string Attach { get; set; }
        public string Datamatrex { get; set; }
        public int NumBand { get; set; }
        public int NumTaslsl { get; set; }
        public int NumDofaa { get; set; }
        public DateTime Date { get; set; }
    }
}
