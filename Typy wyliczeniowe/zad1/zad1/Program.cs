namespace zad1
{
    public class Program
    {
        public static void Main()
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee() { Name = "John", ContractType = 1 };
            employees[1] = new Employee() { Name = "Bob", ContractType = 1 };
            employees[2] = new Employee() { Name = "Steve", ContractType = 2 };
            employees[3] = new Employee() { Name = "Jim", ContractType = 3 };

            foreach (var employee in employees)
            {
                Console.WriteLine("Employee name is : {0} and contract type is {1}", employee.Name, GetContractType(employee.ContractType));
            }
        }

        public enum Contract: byte
        {
            Other,
            Trial,
            Intership,
            Temporary
        }


        static string GetContractType(int contract)
        {
            switch (contract)
            {
                case 1:
                    return Contract.Trial.ToString(); 
                case 2:
                    return Contract.Intership.ToString();
                case 3:
                    return Contract.Temporary.ToString();
                default:
                    return Contract.Other.ToString();
            }
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int ContractType { get; set; }
    }

}