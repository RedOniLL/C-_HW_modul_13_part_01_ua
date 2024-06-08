using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_13_part_01_ua
{
    public static class CompanyExtensions
    {
        public static IEnumerable<Company> GetAllCompanies(this IEnumerable<Company> companies)
        {
            return companies;
        }

        public static IEnumerable<Company> GetCompaniesWithNameContains(this IEnumerable<Company> companies, string keyword)
        {
            return companies.Where(c => c.Name.Contains(keyword));
        }

        public static IEnumerable<Company> GetMarketingCompanies(this IEnumerable<Company> companies)
        {
            return companies.Where(c => c.BusinessProfile == "Marketing");
        }

        public static IEnumerable<Company> GetMarketingOrITCompanies(this IEnumerable<Company> companies)
        {
            return companies.Where(c => c.BusinessProfile == "Marketing" || c.BusinessProfile == "IT");
        }

        public static IEnumerable<Company> GetCompaniesWithMoreThan100Employees(this IEnumerable<Company> companies)
        {
            return companies.Where(c => c.NumberOfEmployees > 100);
        }

        public static IEnumerable<Company> GetCompaniesWithEmployeesInRange(this IEnumerable<Company> companies, int min, int max)
        {
            return companies.Where(c => c.NumberOfEmployees >= min && c.NumberOfEmployees <= max);
        }

        public static IEnumerable<Company> GetCompaniesLocatedInLondon(this IEnumerable<Company> companies)
        {
            return companies.Where(c => c.Address.ToLower().Contains("london"));
        }

        public static IEnumerable<Company> GetCompaniesWithCEOName(this IEnumerable<Company> companies, string lastName)
        {
            return companies.Where(c => c.CEOName.ToLower().Contains(lastName.ToLower()));
        }

        public static IEnumerable<Company> GetCompaniesFoundedBefore(this IEnumerable<Company> companies, DateTime date)
        {
            return companies.Where(c => c.FoundationDate < date);
        }

        public static IEnumerable<Company> GetCompaniesFoundedOnDate(this IEnumerable<Company> companies, DateTime date)
        {
            return companies.Where(c => c.FoundationDate == date);
        }

        public static IEnumerable<Company> GetCompaniesWithCEONameAndKeywordInName(this IEnumerable<Company> companies, string lastName, string keyword)
        {
            return companies.Where(c => c.CEOName.ToLower().Contains(lastName.ToLower()) && c.Name.Contains(keyword));
        }
    }
}
