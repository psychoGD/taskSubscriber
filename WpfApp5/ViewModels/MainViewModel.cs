using Cinema_MVVM_PROJECT_WPF.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.views;

namespace WpfApp5.ViewModels
{
    public class MainViewModel
    {
        public RelayCommand YoutuberCommand { get; set; }
        public RelayCommand SubscriberCommand { get; set; }
        public MainViewModel()
        {
            SubscriberCommand = new RelayCommand(o =>
            {
                var SubscriberMenu = new SubscriberMenuUC();
                SubscriberMenu.DataContext = new SubscriberMenuViewModel();
                App.MainGrid.Children.Add(SubscriberMenu);
            });
        }
    }
}
