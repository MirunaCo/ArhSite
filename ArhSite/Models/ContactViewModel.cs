using System.ComponentModel.DataAnnotations;

namespace ArhSite.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Numele este obligatoriu")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Adresa de mail este obligatorie")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefonul este obligatoriu")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Mesajul este obligatoriu")]
        public string Message { get; set; }
    }
}