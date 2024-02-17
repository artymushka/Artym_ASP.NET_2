using CompanyService.Controllers;

namespace CompanyService.Models // Зміна простору імен на CompanyService.Models
{
    public class HomeViewModel
    {
        public string CompanyWithMostEmployees { get; set; }
        public ConfigData MyInfo { get; set; }
    }
}
