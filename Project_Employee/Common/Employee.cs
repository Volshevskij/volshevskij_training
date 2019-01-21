using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Middle name")]
        [DataType(DataType.Text)]
        public string MidName { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Last name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Department")]
        [DataType(DataType.Text)]
        public string Department { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Department phone")]
        [DataType(DataType.Text)]
        public string DepPhone { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Department adress")]
        [DataType(DataType.Text)]
        public string DepAdress { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Department description")]
        [DataType(DataType.Text)]
        public string DepDescription { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Phone")]
        [DataType(DataType.Text)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Adress")]
        [DataType(DataType.Text)]
        public string Adress { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Status")]
        [DataType(DataType.Text)]
        public string Status { get; set; }

        public byte[] Photo { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Work period")]
        [DataType(DataType.Text)]
        public string WorkPeriod { get; set; }

        [Required(ErrorMessage = "This field must be filled")]
        [Display(Name = "Marital status")]
        [DataType(DataType.Text)]
        public string MaritalStatus { get; set; }

        public string PhotoUrl { get; set; }
    }
}