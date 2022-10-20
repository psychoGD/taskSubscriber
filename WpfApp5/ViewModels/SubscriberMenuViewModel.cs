using Cinema_MVVM_PROJECT_WPF.Commands;
using Cinema_MVVM_PROJECT_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.views;

namespace WpfApp5.ViewModels
{
    public class SubscriberMenuViewModel:BaseViewModel
    {
        public RelayCommand SignInCommand { get; set; }

        public RelayCommand RegisterCommand { get; set; }

        public RelayCommand BackCommand { get; set; }
        public SubscriberMenuViewModel()
        {
            SignInCommand = new RelayCommand(o =>
            {
                
            });
            RegisterCommand = new RelayCommand(o =>
            {
                var registerUC = new RegisterUC();
                registerUC.DataContext = new RegisterViewModel();
                App.MainGrid.Children.Add(registerUC);
            });
            BackCommand = new RelayCommand(o =>
            {
                App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count - 1);
            });
        }
    }
}
