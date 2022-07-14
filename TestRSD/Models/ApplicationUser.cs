using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestRSD.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "تاكد من ادخال كود المستخدم")]
        public int UserCode { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال كود ادارة المصلحه")]
        public int Masla7aManageCode { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال كود اصحاب المصلحه")]
        public int Masla7aCode { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال كود ادارة العمليات")]
        public int OperationsManageCode { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال كلمة مرور ادارة العمليات")]
        public string OperationsManagePass { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال كود الشركة")]
        public string CompanyCode { get; set; }
    }
}
