using System;
using System.Collections.Generic;
using EmployeeDetail.Model;
using Xamarin.Forms;

namespace EmployeeDetail
{
    public partial class EmployeeDetails : ContentPage
    {
        Employee Emp;
        public EmployeeDetails(Employee employee)
        {
            Emp = employee;
            BindingContext = Emp;
            InitializeComponent();

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            DisplayAlert(Emp.FirstName, Emp.Email, Emp.LastName);
        }
    }
    }
