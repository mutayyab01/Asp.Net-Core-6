using Microsoft.AspNetCore.Mvc.Rendering;

namespace BindDropDownlistWithDatabase.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public List<SelectListItem> StudentList { get; set; }
    }
}
