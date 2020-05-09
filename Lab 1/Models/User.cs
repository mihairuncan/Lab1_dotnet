using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class User
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        [MinLength(10)]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string password { get; set; }
        public DateTime LastLoginTime { get; set; }
    }
}
