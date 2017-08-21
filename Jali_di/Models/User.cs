using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Jali_di.Models
{
    public class User
    {
        [Key]
        public int id_user { get; set; }

        [Required(ErrorMessage = "Username required")]
        public string username { get; set; }

        [Required(ErrorMessage = "Email required")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}