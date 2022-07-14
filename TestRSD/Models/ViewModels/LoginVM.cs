using System.ComponentModel.DataAnnotations;

namespace TestRSD.Models.ViewModels
{
    public class LoginVM
    {
        public bool RememberMe { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال البريد الالكتروني")]
        public string Email { get; set; }

        [Required(ErrorMessage = "تاكد من ادخال الرقم السري")]
        public string Password { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال كود المستخدم")]
        public int UserCode { get; set; }
        [Required(ErrorMessage = "تاكد من ادخال كود الشركة")]
        public int CompanyCode { get; set; }
    }
}
