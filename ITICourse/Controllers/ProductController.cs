using ITICourse.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITICourse.Controllers
{
    public class ProductController : Controller
    {
        // 1. Actions can't be private
        // 2. Actions can't be static
        // 3. Actions can't be overloaded

        // Types of action results:
        // 1. ContentResult - returns a string
        // 2. ViewResult - returns an HTML view
        // 3. JavaScriptResult - returns JavaScript (not directly available in ASP.NET Core)
        // 4. JsonResult - returns JSON
        // 5. NotFoundResult - returns a 404 status
        // 6. FileResult - returns a file

        // In JSON, the browser returns all keys in lowercase



        //product/showmix/1?age=44
        //product/showmix?id=2&age=44




        /*
         *   public IActionResult ShowMix(int id,int age)
        {
            if (id % 2 == 0)
            {
                ContentResult contentResult = new ContentResult();
                contentResult.Content = "local Msg";
                return contentResult;
            }
            else
            {
                ViewResult result = new ViewResult();
                result.ViewName = "View1";
                return result;
            }
        }

        public JsonResult ShowJson()
        {
            JsonResult result = new JsonResult(new { ID = 1, Name = "ahmed" });
            return result;
        }

        public IActionResult Index()
        {
            return View();
        }
       
     
         */
        //product/showmg
        public string ShowMG()
        {
            return "hello from first action";
        }

        public IActionResult Details(int id)
        {
            // Initialize the sample data class and retrieve the product by id
            ProductSampleData sampleData = new ProductSampleData();
            Product productModel = sampleData.GetById(id);

            // Send the retrieved product model to the "ProductDetails" view
            return View("ProductDetails", productModel);
        }

        ProductSampleData sampledata=new ProductSampleData();

        public ActionResult index()
        {
            List<Product> productListModel = sampledata.GetAll();
            return View("ShowAll",productListModel);//typeModel list,product>
        }




    }
}
