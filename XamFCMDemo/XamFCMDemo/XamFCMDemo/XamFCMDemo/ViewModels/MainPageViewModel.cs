using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamFCMDemo.Annotations;
using XamFCMDemo.Services;

namespace XamFCMDemo.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand GetTokenCommand { get; }

        public MainPageViewModel()
        {
            GetTokenCommand = new Command(GetTokenCmd);
        }

        private void GetTokenCmd()
        {
            DependencyService.Get<IFirebaseMessanging>().ShowToast();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
