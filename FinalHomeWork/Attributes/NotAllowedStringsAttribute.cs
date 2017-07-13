using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FinalHomeWork.Attributes
{
    public class NotAllowedStringsAttribute: ValidationAttribute
    {
        public string[] NotAllowedStrings { get; private set; }

        private string notAllowedMessage;

        public NotAllowedStringsAttribute(string[] notAllowedStrings)
        {
            this.NotAllowedStrings = notAllowedStrings;
            this.notAllowedMessage = $"帳號不得包含以下字串[{string.Join(",", NotAllowedStrings.Select(x => $"\"{x}\""))}]";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return NotAllowedStrings.Any(x => value.ToString().Contains(x)) ? new ValidationResult(ErrorMessage ??  notAllowedMessage) : ValidationResult.Success;
        }
    }
}