using ModelsinASPCore.Models;

namespace ModelsinASPCore.Repository
{
    public class StudentRepository : Istudent
    {
        public List<StudentModel> GetallStudents()
        {

            return DataSource();


        }
        public StudentModel Getstudent(int id)
        {
            return DataSource().Where(x=>x.rollNo==id).First();
        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>()
            {
                new StudentModel { rollNo = 1, Name = "Mutayyab", Standard = 12, Gender = "Male" },
                new StudentModel { rollNo = 2, Name = "Muneeb", Standard = 11, Gender = "Male" },
                new StudentModel { rollNo = 3, Name = "Maryam", Standard = 12, Gender = "Female" },
                new StudentModel { rollNo = 3, Name = "Faiq", Standard = 17, Gender = "Male" },
                new StudentModel { rollNo = 3, Name = "Anum", Standard = 16, Gender = "Female" },
            };



        }
    }
}
