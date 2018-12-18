using System;
using EmployeeDetail.Model;

namespace EmployeeDetail.ViewModel
{
    public class NewEmployeeViewModel : BaseViewModel
    {
        public string FirstName
        {
            get => _firstName; set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => _lastName; set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => _email; set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public int age;
        public string Age
        {
            get
            {
                return age.ToString();
            }
            set
            {
                try
                {
                    age = int.Parse(value);
                }
                catch
                {
                    if (string.IsNullOrEmpty(value)) age = 0;
                    Age = age.ToString();
                }
                finally
                {
                    OnPropertyChanged();
                }
            }
        }
        public DateTime DataOfJoining
        {
            get => _dataOfJoining; set
            {
                _dataOfJoining = value;
                OnPropertyChanged();
            }
        }
        public DateTime MinDate = new DateTime(2000, 1, 1);
        public DateTime MaxDate = DateTime.Now;
        private string _email;
        private string _lastName;
        private string _firstName;
        private DateTime _dataOfJoining;

        public NewEmployeeViewModel()
        {
            DataOfJoining = DateTime.Now;
        }

        internal bool AddEmployee()
        {
            if (ValidateInput())
            {
                Employee employee = new Employee(FirstName, LastName, age, Email, DataOfJoining);
                PopulateEmployees.AddEmployee(employee);
                return true;
            }
            return false;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(FirstName)) return false;
            if (string.IsNullOrEmpty(LastName)) return false;
            if (age < 20 || age > 62) return false;
            if (string.IsNullOrEmpty(Email)) return false;
            var emailSplit = Email.Split('@');
            if (emailSplit.Length !=2 || string.IsNullOrEmpty(emailSplit[0]) || string.IsNullOrEmpty(emailSplit[1])) return false;
            var suffixSplit = emailSplit[1].Split('.');
            if (suffixSplit.Length < 2) return false;
            if ((((DateTime.Now - DataOfJoining).TotalDays) / 365) > (age - 20)) return false;
             return true;
        }
    }
}
