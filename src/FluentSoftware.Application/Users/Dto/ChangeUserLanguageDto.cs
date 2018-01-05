using System.ComponentModel.DataAnnotations;

namespace FluentSoftware.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}