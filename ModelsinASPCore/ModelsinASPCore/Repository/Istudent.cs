using ModelsinASPCore.Models;

namespace ModelsinASPCore.Repository
{
    public interface Istudent
    {
        List<StudentModel> GetallStudents();
        StudentModel Getstudent(int id);




    }
}
