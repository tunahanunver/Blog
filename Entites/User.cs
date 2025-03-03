﻿using System.ComponentModel.DataAnnotations;

namespace Blog.Entites
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Ad"), StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Soyad"), StringLength(50)]
        public string Surname { get; set; }

        [EmailAddress, StringLength(50)]
        public string Email { get; set; }

        [Display(Name = "Şifre"), StringLength(50)]
        public string Password { get; set; }

        [Display(Name = "Kullanıcı Adı"), StringLength(50)]
        public string? UserName { get; set; }

        [Display(Name = "Durum")]
        public bool IsActive { get; set; }

        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
