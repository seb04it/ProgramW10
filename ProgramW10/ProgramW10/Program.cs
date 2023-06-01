using ProgramW10;

var employee = new Employee("K", "L");
employee.AddGrade("101");
employee.AddGrade("Adam");
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(2000);
var statistics = employee.GetStatistics();

Console.WriteLine($"max: {statistics.Max}");
Console.WriteLine($"min: {statistics.Min}");
Console.WriteLine($"average: {statistics.Average:n2}");