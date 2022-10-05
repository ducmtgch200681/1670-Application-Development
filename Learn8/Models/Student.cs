using System.ComponentModel.DataAnnotations;

namespace Learn8.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "It nhat 3 chu thang ngu")]
        [MaxLength(30, ErrorMessage = "Ten deo gi dai the thang dan?")]
        public string Name { get; set; }
        [Range(18,30,ErrorMessage = "Duoi 30 thoi chu gia qua sao choi")]
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        //[Url]
        public string Image { get; set; }
        [Phone]
        [StringLength(10, MinimumLength = 10)]
        public string Mobile { get; set; }
    }
}
