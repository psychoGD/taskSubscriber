using Cinema_MVVM_PROJECT_WPF.Commands;
using Cinema_MVVM_PROJECT_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.Models;

namespace WpfApp5.ViewModels
{
    public class SignInViewModel:BaseViewModel
    {
        public RelayCommand SignInCommand { get; set; }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value;OnPropertyChanged(); }
        }

        public SignInViewModel(string username="")
        {
            this.username = username;
            SignInCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count - 1);
                
            });
        }
    }
}
