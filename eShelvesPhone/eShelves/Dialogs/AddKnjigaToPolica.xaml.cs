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
using Windows.Storage.Pickers.Provider;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eShelves.Dialogs
{
    public sealed partial class AddKnjigaToPolica : ContentDialog
    {
        WebApiHelper policeService = new WebApiHelper(Config.urlApi, "Police/All");
        WebApiHelper btnService = new WebApiHelper(Config.urlApi, "Desktop/AddKnjigaToPolica");
        private int KnjigaID;

        public AddKnjigaToPolica(int knjigaID)
        {
            this.InitializeComponent();

            KnjigaID = knjigaID;

            HttpResponseMessage response = policeService.GetResponse(Global.prijavljeniKorisnik.Id.ToString());

            if (response.IsSuccessStatusCode)
            {
                List<HubPageViewModel.ShelvesInfo.ShelfInfo> police = response.Content.ReadAsAsync<List<HubPageViewModel.ShelvesInfo.ShelfInfo>>().Result;
                listaPolica.ItemsSource = police;
            }
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            HubPageViewModel.ShelvesInfo.ShelfInfo item = (HubPageViewModel.ShelvesInfo.ShelfInfo)e.ClickedItem;

            HttpResponseMessage response = btnService.GetResponse(item.ShelfID + "/" + KnjigaID);

            if (response.IsSuccessStatusCode)
            {
                MessageDialog msg = new MessageDialog("Knjiga uspješno dodana u policu!");
                msg.ShowAsync();
            }
            Hide();
        }
    }
}
