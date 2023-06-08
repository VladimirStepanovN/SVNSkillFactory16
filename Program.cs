namespace SVNSkillFactory16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }
        static Department GetCurrentDepartment()
        {
            Department department = new Department();
            department.Company = new Company();
            department.City = new City();
            if ("Банк".Equals(department?.Company?.Type)
                && "Санкт-Петербург".Equals(department?.City?.Name))
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
            return department;
        }
        class Company
        {
            public string Type = "Банк";
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name = "Санкт-Петербург";
        }
    }
}