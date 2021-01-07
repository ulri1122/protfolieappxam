using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class about_me : ContentPage
    {
        public about_me()
        {
            InitializeComponent();
        }
        private void PlacePhoneCall(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("50406616");
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
        private void openMail(object sender, EventArgs e)
        {
            var address = "ulri1122@gmail.com";
            Device.OpenUri(new Uri($"mailto:{address}"));
        }
        private void openAddress(object sender, EventArgs e)
        {
            Launcher.OpenAsync("geo:0,0?q=Mercantec, H. C. Andersens Vej, Viborg");   
        }
        private void openGitHub(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://github.com/ulri1122/", BrowserLaunchMode.SystemPreferred);
        }
    }
}