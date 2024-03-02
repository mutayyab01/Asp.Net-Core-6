using System.ComponentModel.DataAnnotations;

namespace TagHelperDemo.Models
{
    public class Employee
    {
        [StringLength(3)]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int salary { get; set; }
        public Gender Gender { get; set; }
        public  string Married { get; set; }
        public string Description { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,

    }
}
