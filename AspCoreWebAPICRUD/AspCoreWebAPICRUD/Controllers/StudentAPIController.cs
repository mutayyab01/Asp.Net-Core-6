using AspCoreWebAPICRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreWebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly EmployeeContext context;

        public StudentAPIController(EmployeeContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> Getstudent()
        {
            var data = await context.Students.ToListAsync();

            return Ok(data);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetstudentById(int id)
        {
            var data = await context.Students.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }


        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student std)
        {
            await context.Students.AddAsync(std);
            await context.SaveChangesAsync();
            return Ok(std);

        }



        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> UpdateStudentbyID(int id, Student std)
        {
            if (id != std.Id)
            {
                return BadRequest();
            }
            context.Entry(std).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(std);

        }




        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudentbyID(int id)
        {
            var std = await context.Students.FindAsync(id);
            if (std == null)
            {
                return NotFound();
            }
            context.Students.Remove(std);
            await context.SaveChangesAsync();
            return Ok(std);
            //return Ok();
        }



























    }
}
