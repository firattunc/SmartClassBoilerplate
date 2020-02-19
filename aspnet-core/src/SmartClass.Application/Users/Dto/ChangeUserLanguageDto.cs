using System.ComponentModel.DataAnnotations;

namespace SmartClass.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}