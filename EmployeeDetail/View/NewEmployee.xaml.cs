using System;
using System.Collections.Generic;
using EmployeeDetail.ViewModel;
using Xamarin.Forms;

namespace EmployeeDetail
{
    public partial class NewEmployee : ContentPage
    {
        private NewEmployeeViewModel vm;
        public NewEmployee()
        {
            vm = new NewEmployeeViewModel();
            BindingContext = vm;
            InitializeComponent();

        }
        void ClickedAddEmployee(object sender, System.EventArgs e)
        {
            //DisplayAlert("GHello", vm.AddEmployee().ToString(), "ye");
            vm.AddEmployee();
            Navigation.PopAsync();
        }            
    }
}
