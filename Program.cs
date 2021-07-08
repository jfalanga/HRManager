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
            hrEmp.FirstName = "CS";
            hrEmp.LastName = "Lewis";
            Console.WriteLine("hrEmp's- or {0} {1}'s- pay summery would be: {2}",hrEmp.FirstName,hrEmp.LastName,hrEmp.GetPaySummary());
            Employee emp2 = hrEmp;
            Console.WriteLine("But emp2's pay summery is: "+emp2.GetPaySummary());
            Console.WriteLine("...AND, ");
        }
    }
}
