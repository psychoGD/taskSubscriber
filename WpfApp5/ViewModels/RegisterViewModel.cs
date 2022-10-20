using Cinema_MVVM_PROJECT_WPF.Commands;
using Cinema_MVVM_PROJECT_WPF.ViewModels;
using System;
using System.Windows;
using System.Windows.Threading;
using WpfApp5.Models;
using WpfApp5.views;

namespace WpfApp5.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public RelayCommand BackCommand { get; set; }
        public RelayCommand RegisterCommand { get; set; }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged(); }
        }
        private string errorText;

        public string ErrorText
        {
            get { return errorText; }
            set { errorText = value; OnPropertyChanged(); }
        }
        private DispatcherTimer updateTimer;

        private void initTimer()
        {
            updateTimer = new DispatcherTimer(DispatcherPriority.SystemIdle);
            updateTimer.Tick += new EventHandler(OnUpdateTimerTick);
            updateTimer.Interval = TimeSpan.FromMilliseconds(2000);
            updateTimer.Start();
        }

        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            ErrorText = "";
        }
        public void BackFunc()
        {
            App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count - 1);
        }
        public void CreateAddSignInUC(string username)
        {
            var signInUC = new SignInUC();
            var ViewModel = new SignInViewModel();
            ViewModel.Username = username;
            signInUC.DataContext = ViewModel;
            App.MainGrid.Children.Add(signInUC);
        }
        public RegisterViewModel()
        {
            BackCommand = new RelayCommand(o =>
            {
                BackFunc();
            });
            RegisterCommand = new RelayCommand(o =>
            {
                if(username != null && username != String.Empty && username.Length>=6)
                {
                    int index = App.database.CheckSubscriberExist(username);
                    if (index == -1)
                    {
                        MessageBox.Show("User Created Succesfully");
                        App.database.Subsribers.Add(new Subscriber(Username));
                        BackFunc();
                        CreateAddSignInUC(username);
                    }
                    else
                    {
                        ErrorText = "This Username Exist!";
                        initTimer();
                    }
                }
                else
                {
                    ErrorText = "Username Must Be Longer Than 6";
                    initTimer();
                }
            });
        }
    }
}
