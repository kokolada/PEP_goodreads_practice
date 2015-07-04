using eShelves.Common;
using eShelves.Dialogs;
using eShelves.Models;
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
using Windows.Graphics.Display;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eShelves
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KnjigaDetalji : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        WebApiHelper knjigaDetaljiService = new WebApiHelper(Config.urlApi, "PhoneKnjigaDetalji");
        WebApiHelper reklamaService = new WebApiHelper(Config.urlApi, "Reklama/RandomAktivna");
        WebApiHelper btnService = new WebApiHelper(Config.urlApi, "Desktop");

        public KnjigaDetalji()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            int knjigaid = (int)e.NavigationParameter;
            HttpResponseMessage response = knjigaDetaljiService.GetResponse(knjigaid + "/" + Global.prijavljeniKorisnik.Id);

            if (response.IsSuccessStatusCode)
            {
                KnjigaDetaljiViewModel model = response.Content.ReadAsAsync<KnjigaDetaljiViewModel>().Result;
                defaultViewModel["detalji"] = model;

                if (model.OcjenaLogiranogKorisnika != null)
                    ocjenaInput.Text = model.OcjenaLogiranogKorisnika + "";

                if (model.IsInPolica)
                {
                    dodajBtn.Visibility = Visibility.Collapsed;
                    ukloniBtn.Visibility = Visibility.Visible;
                }
                else
                {
                    dodajBtn.Visibility = Visibility.Visible;
                    ukloniBtn.Visibility = Visibility.Collapsed;
                }

                HttpResponseMessage r = reklamaService.GetResponse();

                if (r.IsSuccessStatusCode)
                {
                    Reklama reklama = r.Content.ReadAsAsync<Reklama>().Result;
                    reklamaS.Source = new BitmapImage(new Uri(reklama.URL, UriKind.Absolute));
                }
            }
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void ocjeneLista_ItemClick(object sender, ItemClickEventArgs e)
        {
            KnjigaDetaljiViewModel.OcjenaInfo item = (KnjigaDetaljiViewModel.OcjenaInfo)(e.ClickedItem);
            Frame.Navigate(typeof(OcjenaDetalji), item.OcjenaID);
        }

        private void dodajBtn_Click(object sender, RoutedEventArgs e)
        {
            KnjigaDetaljiViewModel model = (KnjigaDetaljiViewModel)defaultViewModel["detalji"];
            AddKnjigaToPolica dialog = new AddKnjigaToPolica(model.KnjigaID);
            dialog.ShowAsync();
            dialog.Closed += dialog_Closed;
        }

        void dialog_Closed(ContentDialog sender, ContentDialogClosedEventArgs args)
        {
            KnjigaDetaljiViewModel model2 = (KnjigaDetaljiViewModel)defaultViewModel["detalji"];

            HttpResponseMessage response = knjigaDetaljiService.GetResponse(model2.KnjigaID + "/" + Global.prijavljeniKorisnik.Id);

            if (response.IsSuccessStatusCode)
            {
                KnjigaDetaljiViewModel model = response.Content.ReadAsAsync<KnjigaDetaljiViewModel>().Result;
                defaultViewModel["detalji"] = model;

                if (model.IsInPolica)
                {
                    dodajBtn.Visibility = Visibility.Collapsed;
                    ukloniBtn.Visibility = Visibility.Visible;
                }
                else
                {
                    dodajBtn.Visibility = Visibility.Visible;
                    ukloniBtn.Visibility = Visibility.Collapsed;
                }

                HttpResponseMessage r = reklamaService.GetResponse();

                if (r.IsSuccessStatusCode)
                {
                    Reklama reklama = r.Content.ReadAsAsync<Reklama>().Result;
                    reklamaS.Source = new BitmapImage(new Uri(reklama.URL, UriKind.Absolute));
                }
            }
        }

        private void ukloniBtn_Click(object sender, RoutedEventArgs e)
        {
            KnjigaDetaljiViewModel model = (KnjigaDetaljiViewModel)defaultViewModel["detalji"];

            HttpResponseMessage response = btnService.GetResponse("RemoveKnjiga/" + model.PolicaID + "/" + model.KnjigaID);

            if (response.IsSuccessStatusCode)
            {
                MessageDialog msg = new MessageDialog("Knjiga uspješno uklonjena!");
                msg.ShowAsync();
                ukloniBtn.Visibility = Visibility.Collapsed;
                dodajBtn.Visibility = Visibility.Visible;
            }
        }

        private void ocjenaBtn_Click(object sender, RoutedEventArgs e)
        {
            KnjigaDetaljiViewModel model = (KnjigaDetaljiViewModel)defaultViewModel["detalji"];

            Frame.Navigate(typeof(OcjeniKnjiguPage), model.KnjigaID);
        }

        private void autor_Tapped(object sender, TappedRoutedEventArgs e)
        {
            KnjigaDetaljiViewModel model = (KnjigaDetaljiViewModel)defaultViewModel["detalji"];

            Frame.Navigate(typeof(AutorPage), model.AutorID);
        }
    }
}
