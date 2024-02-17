using Microsoft.AspNetCore.Mvc;

namespace CompanyService.Controllers
{
    public class ConfigData
    {
        public string Name { get; set; }
        public string Secondname { get; set; }
        public string City { get; set; }
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                CompanyWithMostEmployees = "Компанія з найбільшою кількістю співробітників - Facebook",
                MyInfo = new ConfigData
                {
                    Name = "Vlad",
                    Secondname = "Artym",
                    City = "Mykolaiv"
                }
            };

            return View(viewModel);
        }

    }

    // Визначення класу HomeViewModel
    public class HomeViewModel
    {
        public string CompanyWithMostEmployees { get; set; }
        public ConfigData MyInfo { get; set; }
    }
}

