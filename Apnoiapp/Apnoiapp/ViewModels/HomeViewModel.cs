using Apnoiapp.Models;
using Apnoiapp.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Apnoiapp.ViewModels
{
    public class HomeViewModel
    {
        public ICommand ScheduleCommand { get; set; }
        public ICommand FinswimmingRegistrationFormCommand { get; set; }
        public ICommand GoToEventsPageCommand { get; set; }

        public HomeViewModel()
        {
            ScheduleCommand = new Command(async () =>
            {
                var id = (int)MenuItemType.ClassSchedule;

                var mainPage = (App.Current.MainPage as MainPage);
                await mainPage.NavigateFromMenu(id);

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);
            });

            GoToEventsPageCommand = new Command(async () =>
            {
                var id = (int)MenuItemType.Events;

                var mainPage = (App.Current.MainPage as MainPage);
                await mainPage.NavigateFromMenu(id);

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);
            });

            FinswimmingRegistrationFormCommand = new Command(async () =>
            {
                Page fsform = new Views.RegistrationForms.FinswimmingRegistrationPage();

                await Application.Current.MainPage.Navigation.PushModalAsync(fsform);
            });
        }
    }
}
