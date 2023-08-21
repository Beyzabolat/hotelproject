﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "İsim alanı zorunludur")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyisim alanı zorunludur")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail alanı zorunludur")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı zorunludur")]
        [Compare("Password", ErrorMessage ="Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }

    }
}
