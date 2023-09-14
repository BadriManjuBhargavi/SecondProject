using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]

        public string UserPwd { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]

        public string UserEmail { get; set; }

    }
}
