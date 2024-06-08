namespace C__HW_modul_13_part_01_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new List<Company>
                {
                    new Company { Name = "Foodie Ltd", FoundationDate = new DateTime(2010, 5, 15), BusinessProfile = "Food", CEOName = "John White", NumberOfEmployees = 150, Address = "123 Main St, London" },
                    new Company { Name = "Tech Solutions", FoundationDate = new DateTime(2015, 8, 20), BusinessProfile = "IT", CEOName = "Jane Black", NumberOfEmployees = 200, Address = "456 Tech Blvd, New York" },
                };

            var foodCompanies = companies.GetCompaniesWithNameContains("Food");

            Console.WriteLine("Companies with name containing 'Food':");
            foreach (var company in foodCompanies)
            {
                Console.WriteLine(company.Name);
            }
            Console.WriteLine();

            
            var employees = new List<Employee>
                {
                    new Employee { FullName = "Alice Smith", Position = "Manager", ContactNumber = "234567890", Email = "alice@example.com", Salary = 50000 },
                    new Employee { FullName = "Bob Johnson", Position = "Developer", ContactNumber = "230987654", Email = "bob@example.com", Salary = 60000 },
                    new Employee { FullName = "Lionel Messi", Position = "Manager", ContactNumber = "230123456", Email = "lionel@example.com", Salary = 80000 },
                    new Employee { FullName = "David Beckham", Position = "Developer", ContactNumber = "239876543", Email = "david@example.com", Salary = 70000 }
                };

            var highPaidEmployees = employees.GetEmployeesWithSalaryGreaterThan(60000);

            Console.WriteLine("Employees with salary greater than 60000:");
            foreach (var employee in highPaidEmployees)
            {
                Console.WriteLine(employee.FullName);
            }
        
    }
    }
}
