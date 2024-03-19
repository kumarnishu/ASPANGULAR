using System.ComponentModel.DataAnnotations;

namespace ASPANGULAR.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}