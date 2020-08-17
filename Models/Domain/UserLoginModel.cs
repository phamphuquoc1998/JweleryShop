using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.Domain
{
    public class UserLoginModel
    {
        [Key]
        public int UserID { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DataType("Password")]
        public string Password { get; set; }
        [NotMapped]
        public bool RememberMe { get; set; }
    }
}
