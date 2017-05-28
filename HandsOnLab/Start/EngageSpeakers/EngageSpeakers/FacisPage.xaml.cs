using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EngageSpeakers
{
    public partial class FacisPage : ContentPage
    {
        public FacisPage()
        {
            InitializeComponent();
        }


        async Task<ObservableCollection<Faci>> GetSpeakers()
        {
            ObservableCollection<Faci> speakers = new ObservableCollection<Faci>();
            try
            {
                //Get list of Facilitators using Azure service
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
                await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
            }

            return speakers;
        }
    }
}