using CRUDAppUsingAspCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CRUDAppUsingAspCoreWebAPI.Controllers
{
    public class StudentController : Controller
    {
        private string URL = "https://localhost:7196/api/StudentAPI/";
        private HttpClient client = new HttpClient();
        [HttpGet]
        public IActionResult Index()
        {

            try
            {
                List<Student> students = new List<Student>();
                HttpResponseMessage response = client.GetAsync(URL).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<List<Student>>(result);
                    if (data != null)
                    {
                        students = data;
                    }
                }
                return View(students);
            }
            catch (Exception)
            {
                ViewBag.exception = "No Data Found Please Check Your URL";
                return View();
            }

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            var Data = JsonConvert.SerializeObject(std);
            StringContent content = new StringContent(Data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(URL, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["insert_data"] = "Inerted Successfully";
                return RedirectToAction("index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student student = new Student();
            HttpResponseMessage response = client.GetAsync(URL + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Student>(result);
                if (data != null)
                {
                    student = data;
                }
            }
            return View(student);

        }


        [HttpPost]
        public IActionResult Edit(Student std)
        {
            var Data = JsonConvert.SerializeObject(std);
            StringContent content = new StringContent(Data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(URL + std.id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["update_data"] = "Updated Successfully";
                return RedirectToAction("index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult Details(int id)
        {

            try
            {
                Student students = new Student();
                HttpResponseMessage response = client.GetAsync(URL + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Student>(result);
                    if (data != null)
                    {
                        students = data;
                    }
                }
                return View(students);
            }
            catch (Exception)
            {
                ViewBag.exception = "No Data Found Please Check Your URL";
                return View();
            }

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            try
            {
                Student students = new Student();
                HttpResponseMessage response = client.GetAsync(URL + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<Student>(result);
                    if (data != null)
                    {
                        students = data;
                    }
                }
                return View(students);
            }
            catch (Exception)
            {
                ViewBag.exception = "No Data Found Please Check Your URL";
                return View();
            }

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            try
            {
                HttpResponseMessage response = client.DeleteAsync(URL + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    TempData["delete_data"] = "Deleted Successfully";
                    return RedirectToAction("index");

                }
                return View();
            }
            catch (Exception)
            {
                ViewBag.exception = "No Data Found Please Check Your URL";
                return View();
            }

        }
    }
}
