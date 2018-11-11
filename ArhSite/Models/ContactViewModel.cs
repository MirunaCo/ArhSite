using System.ComponentModel.DataAnnotations;

namespace ArhSite.Models
{
   public class ContactViewModel
   {
      [Required]
      public string FullName { get; set; }

      [Required]
      [DataType(DataType.EmailAddress)]
      [EmailAddress]
      public string Email { get; set; }

      [Required]
      [DataType(DataType.PhoneNumber)]
      public string PhoneNumber { get; set; }

      [Required]
      public string Message { get; set; }
   }
}