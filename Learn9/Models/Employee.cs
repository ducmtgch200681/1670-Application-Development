using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Learn9.Models
{
    public class Employee
    {
        [Required (ErrorMessage = "write it down")]
        [StringLength (10, MinimumLength = 3, ErrorMessage = "3 to 10")]
        public string Name { get; set; }

        [MinLength(5, ErrorMessage = "atlease 5")]
        [MaxLength(50, ErrorMessage = "max 50")]
        public string Address { get; set; }

        [Required (ErrorMessage ="write it")]
        public string position { get; set; }

        [Required(ErrorMessage ="Ngay thang nam sinh")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        //[MinLength(5, ErrorMessage = "5")]
        //[MaxLength(10, ErrorMessage = "10")]
        //public string Address { get; set; }
    }
}
