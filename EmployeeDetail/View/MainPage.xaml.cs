using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDetail.Model;
using EmployeeDetail.ViewModel;
using Xamarin.Forms;

namespace EmployeeDetail
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new MainPageViewModel();
            BindingContext = vm;
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new EmployeeDetails((Employee)e.SelectedItem));
        }

        void ClickedAddEmployee(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewEmployee());
        }
    }
}
