using System.ComponentModel.DataAnnotations;

namespace Task_1.Models
{
    public class User
    {

        /*[Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Name can't containt special symbols or numbers")]
        [Range(3, 30, ErrorMessage = "Name too short or too long!")]*/
        public string Name { get; set; } = string.Empty;

    }
}
