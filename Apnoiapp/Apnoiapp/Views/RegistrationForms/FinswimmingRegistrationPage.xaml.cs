using Apnoiapp.ViewModels.RegistrationForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Apnoiapp.Views.RegistrationForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FinswimmingRegistrationPage : ContentPage
	{
		public FinswimmingRegistrationPage ()
		{
			InitializeComponent ();

            BindingContext = new FinswimmingFormViewModel();

        }
	}
}