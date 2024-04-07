using ImageUploadingAspCore.Model;
using ImageUploadingAspCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace ImageUploadingAspCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ImageDBContext imageDBContext;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductController(ImageDBContext imageDBContext, IWebHostEnvironment webHostEnvironment)
        {
            this.imageDBContext = imageDBContext;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {


            return View(imageDBContext.ProductTables.ToList());
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(ProductViewModel product)
        {
            string fileName = "";


            if (ModelState.IsValid)
            {
                var ext = Path.GetExtension(product.Photo.FileName);
                var size = product.Photo.Length;
                if (ext == ".png" || ext == ".jpeg" || ext == ".jpg")
                {
                    if (size <= 1000000)//1Mb
                    {

                        string folderPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
                        fileName = Guid.NewGuid().ToString() + "_" + product.Photo.FileName;
                        string FilePath = Path.Combine(folderPath, fileName);
                        product.Photo.CopyTo(new FileStream(FilePath, FileMode.Create));
                        ProductTable p = new ProductTable()
                        {
                            Name = product.Name,
                            Price = product.Price,
                            ImagePath = fileName
                        };
                        imageDBContext.ProductTables.Add(p);
                        imageDBContext.SaveChanges();
                        TempData["success"] = "Product Added";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["sizeError"] = "Image Must be less Than 1 Mb";
                    }

                }
                else
                {
                    TempData["extError"] = "Only PNG,JPEG,JPG Pictures Are Allowed";
                }

            }



            return View();
        }
    }
}
