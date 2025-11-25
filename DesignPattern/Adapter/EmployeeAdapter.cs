// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employees)
        {
            var employeesAdapted = new List<Employee>();
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                int id = int.Parse(employees[i, 0]);
                string name = employees[i, 1];
                string designation = employees[i, 2];
                decimal salary = decimal.Parse(employees[i, 3]);

                employeesAdapted.Add(new Employee(id, name, designation, salary));
            }
            
            thirdPartyBillingSystem.ProcessSalary(employeesAdapted);
        }
    }
}
