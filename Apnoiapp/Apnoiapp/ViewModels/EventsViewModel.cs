using Apnoiapp.Views.RegistrationForms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Apnoiapp.ViewModels
{
    public class EventsViewModel
    {
        public ICommand FinswimmingRegistrationFormCommand { get; set; }

        public EventsViewModel()
        {
            FinswimmingRegistrationFormCommand = new Command(async () =>
            {
                Page fsform = new FinswimmingRegistrationPage();

                await Application.Current.MainPage.Navigation.PushModalAsync(fsform);
            });
        }
    }
}
