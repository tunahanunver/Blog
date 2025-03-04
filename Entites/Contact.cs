using System.ComponentModel.DataAnnotations;

namespace Blog.Entites
{
    public class Contact
    {
        public int Id { get; set; }

        [Display(Name = "Ad"), StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Soyad"), StringLength(50)]
        public string Surname { get; set; }

        [EmailAddress, StringLength(50)]
        public string Email { get; set; }

        [Phone, StringLength(50)]
        public string Phone { get; set; }

        [Display(Name = "Mesaj"), StringLength(500)]
        public string Message { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
