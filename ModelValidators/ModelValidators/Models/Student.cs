using System.ComponentModel.DataAnnotations;

namespace ModelValidators.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name Enter Kro")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "3 se xayda daal")]
        [Display(Name = "Enter Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Email Enter Kro")]
        [EmailAddress]
        [Display(Name = "Enter Email")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Age Enter Kro")]
        [Range(10, 50)]
        [Display(Name = "Enter Age")]
        public int? Age { get; set; }
        //[Required(ErrorMessage = "Password Enter Kro")]
        //[RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Please Enter Strong Password")]
        //public string Password { get; set; }
        //[Required(ErrorMessage = "Confirm Password Enter Kro")]
        //[Compare("Password",ErrorMessage ="Both Password Must bi identical")]
        //public string Cpassword { get; set; }

        //[Required(ErrorMessage = "Website URl is Must")]
        //[Url(ErrorMessage ="Invalid URL")]
        //public string WebsiteURL { get; set; }
    }
}
