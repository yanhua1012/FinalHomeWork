using System.ComponentModel.DataAnnotations;
using FinalHomeWork.Attributes;

namespace FinalHomeWork.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage ="{0} 的格式需為 E-Mail")]
        [Display(Name = "帳號")]
        [NotAllowedStrings(new string[] { "skilltree","demo","twMVC" })]
        public string Account { get; set; }

        [Required]
        [Display(Name = "密碼")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{0}必須{1}字元以上{2}字元以下")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "記住我")]
        public bool RememberMe { get; set; }
    }
}