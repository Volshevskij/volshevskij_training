using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Task_17.Models
{
    public class User
    {
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [MaxLength(14), MinLength(2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [MaxLength(20), MinLength(5)]
        public string MidName { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [MaxLength(14), MinLength(2)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Range(18,100)]
        public string Age { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Phone]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Adress { get; set; }
        [Key]
        public int Id { get; set; }
    }
}