using System;

namespace HRManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            HourlyEmployee hrEmp = new HourlyEmployee();
            emp.FirstName = "Thomas";
            emp.LastName = "Aquinas";
            Console.WriteLine("emp's ({0},{1}) pay summery is: {2}", emp.LastName,emp.FirstName,emp.GetPaySummary());
            
            Console.WriteLine("Now, emp's ToString: {0}. It's GetType is: {1}; while it's GetHashCode is {2}",
                emp.ToString(),emp.GetType(),emp.GetHashCode());
            Console.WriteLine();
            Console.WriteLine();

            hrEmp.FirstName = "CS";
            hrEmp.LastName = "Lewis";
            Console.WriteLine("hrEmp's- or {0} {1}'s- pay summery would be: {2}",hrEmp.FirstName,hrEmp.LastName,hrEmp.GetPaySummary());
            Console.WriteLine("hrEmp's ToString is: {0}", hrEmp.ToString());

            Employee emp2 = hrEmp;
            Console.WriteLine("But emp2's (which should be the same as hrEmp) pay summery is: "+emp2.GetPaySummary());
            emp.something = 200;
            Console.WriteLine("Something about emp is: "+emp.something);
            Console.WriteLine("Trying to make hrEmp's something the same...");
            hrEmp.something = 200;
            Console.WriteLine("...but it's "+hrEmp.something);
            Console.WriteLine("Maybe emp2 can be 10...");
            emp2.something = 10;
            Console.WriteLine(emp2.something+"No! It's "+emp2.something);
        }
    }
}
