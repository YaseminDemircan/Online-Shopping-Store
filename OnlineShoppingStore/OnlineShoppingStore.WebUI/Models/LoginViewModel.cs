using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.WebUI.Models
{
    
    public class LoginViewModel
    {
        [Required(ErrorMessage="Kullanıcı ismi gereklidir.")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Şifre gereklidir.")]
        [StringLength(50,MinimumLength =6)]
        public string Password { get; set; }
    }
}