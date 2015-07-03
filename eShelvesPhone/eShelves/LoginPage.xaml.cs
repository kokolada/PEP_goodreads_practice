using eShelves.Util;
using eShelves.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eShelves
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        WebApiHelper serviceCaller = new WebApiHelper(Config.urlApi, "test");

        public LoginPage()
        {
            this.InitializeComponent();
            //HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();

            e.Handled = true;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            usernameInput.Text = "dzemo";
            passwordInput.Password = "gigant";
            if (Global.prijavljeniKorisnik != null)
                Frame.Navigate(typeof(HubPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegisterPage));
        }

        private async void loginButton_Click(object sender, RoutedEventArgs e)
        {
            HttpResponseMessage response = serviceCaller.GetResponse("?username=" + usernameInput.Text + "&password=" + passwordInput.Password);

            if (response.IsSuccessStatusCode)
            {
                LogiraniKorisnik korisnik = response.Content.ReadAsAsync<LogiraniKorisnik>().Result;
                if (korisnik != null)
                {
                    Global.prijavljeniKorisnik = korisnik;
                    Frame.Navigate(typeof(HubPage));
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Pogrešan username ili password");
                    await msg.ShowAsync();
                }
            }
            else
            {
                MessageDialog msg = new MessageDialog("Api error!");
                await msg.ShowAsync();
            }
        }
    }
}
