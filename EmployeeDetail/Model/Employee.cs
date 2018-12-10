using System;
using Xamarin.Forms;
namespace EmployeeDetail.Model
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string DOJString { 
        get {
                var str = DateOfJoining.ToLongDateString();
                string[] str1 = str.Split(',');
                string[] str2 = new string[2];
                Array.Copy(str1,1, str2,0,2);
                return string.Join(",", str2);
        } }
        public Employee(string fn,string ln,int age,string eml,DateTime doj)
        {
            FirstName = fn;
            LastName = ln;
            Age = age;
            Email = eml;
            DateOfJoining =doj;
        }
        public Employee()
        {

        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age}, {Email}, {DOJString}";
        }
    }
}
