
namespace CompanyService
{
    public class EmployeeService
    {
        private readonly IConfiguration _configuration;

        public EmployeeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetCompanyWithMostEmployees()
        {
            int maxEmployees = 0;
            string companyName = "";

            var companies = new string[] { "Amazon", "Facebook", "Twitter" };
            foreach (var company in companies)
            {
                var employees = _configuration.GetValue<int>($"{company}:employees");
                if (employees > maxEmployees)
                {
                    maxEmployees = employees;
                    companyName = company;
                }
            }

            return companyName;
        }
    }
}

