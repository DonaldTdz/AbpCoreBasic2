using System.ComponentModel.DataAnnotations;

namespace AbpCoreBasic.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}