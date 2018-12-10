using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EmployeeDetail.Model;
namespace EmployeeDetail.ViewModel
{
    public class MainPageViewModel:BaseViewModel { 
    public ObservableCollection<Employee> Employees { get; set; }
    public MainPageViewModel()
        {
            PopulateEmployees();
            Employees = Model.PopulateEmployees.Employees;
        }
        public async void PopulateEmployees()
        {
            await Model.PopulateEmployees.Populate(10);

        }
    }
}
