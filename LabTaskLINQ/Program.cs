namespace LabTaskLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30 };

            var cities = new List<string>
            { "New York", "London", "Tokyo", "Paris", "Berlin", "Sydney", "Toronto", "Mumbai", "Barcelona" };

            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Smith", Department = "IT", Salary = 75000, Age = 28 },
                new Employee { Id = 2, Name = "Sarah Johnson", Department = "HR", Salary = 65000, Age = 32 },
                new Employee { Id = 3, Name = "Mike Wilson", Department = "IT", Salary = 85000, Age = 35 },
                new Employee { Id = 4, Name = "Emily Davis", Department = "Finance", Salary = 70000, Age = 29 },
                new Employee { Id = 5, Name = "David Brown", Department = "IT", Salary = 95000, Age = 40 },
                new Employee { Id = 6, Name = "Lisa Garcia", Department = "Marketing", Salary = 60000, Age = 26 },
                new Employee { Id = 7, Name = "Robert Taylor", Department = "Finance", Salary = 80000, Age = 38 },
                new Employee { Id = 8, Name = "Jennifer Lee", Department = "HR", Salary = 55000, Age = 24 }
            };

            var orders = new List<Order>
            {
            new Order { Id = 1, CustomerName = "Alice", Amount = 150.50m, OrderDate = new DateTime(2024, 1, 15) },
            new Order { Id = 2, CustomerName = "Bob", Amount = 89.99m, OrderDate = new DateTime(2024, 2, 10) },
            new Order { Id = 3, CustomerName = "Alice", Amount = 200.00m, OrderDate = new DateTime(2024, 1, 25) },
            new Order { Id = 4, CustomerName = "Charlie", Amount = 75.25m, OrderDate = new DateTime(2024, 3, 5) },
            new Order { Id = 5, CustomerName = "Bob", Amount = 120.75m, OrderDate = new DateTime(2024, 2, 20) },
            new Order { Id = 6, CustomerName = "Diana", Amount = 300.00m, OrderDate = new DateTime(2024, 1, 30) }
            };


            //1
            //var even = numbers.Where(n => n % 2 == 0);
            //foreach (var item in even) Console.WriteLine(item);

            //2
            //var specificStr = cities.Where(c => c.StartsWith("L") || c.StartsWith("T"));
            //foreach (var str in specificStr) Console.WriteLine(str);

            //3
            //var maxSalary = employees.Max(x => x.Salary);
            //Console.WriteLine(maxSalary);

            //4
            //var young = employees.Where(y => y.Age < 30).ToList();
            //foreach (var order in young) Console.WriteLine($"{order.Name} " + $" {order.Age}");

            //5
            //var square = numbers.Select(s => s * s).ToList();
            //foreach(var item in square) Console.WriteLine(item);

            //6
            //var lengths = cities.Select(c => new { Name = c, chCount = c.Length }).ToList();
            //foreach (var length in lengths) Console.WriteLine($"{length.Name} " + $" {length.chCount}");

            //7
            //var employeeName = employees.Select(n => n.Name);
            //foreach (var item in employees) Console.WriteLine(item.Name);

            //8
            //var employeeSummary = employees.Select(e => new
            //{
            //    Name = e.Name,
            //    Department = e.Department,
            //    IsAboveAverage = e.Salary > employees.Average(e => e.Salary)
            //});

            //foreach (var item in employeeSummary)
            //{
            //    Console.WriteLine($"Name: {item.Name} , departament: {item.Department} , Average: {item.IsAboveAverage}");
            //}
        }

    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

