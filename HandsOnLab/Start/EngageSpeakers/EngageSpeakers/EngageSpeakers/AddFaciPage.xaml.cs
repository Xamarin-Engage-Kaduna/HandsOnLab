using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EngageSpeakers
{
    public partial class AddFaciPage : ContentPage
    {
        Faci Faci;
        public AddFaciPage(Faci faci)
        {
            InitializeComponent();
            Faci = faci;
            BindingContext = faci;
        }


        //Add a New User
        async Task AddUser()
        {
            try
            {
                //Add User using Azure Service
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
               
            }
        }
    }
}
