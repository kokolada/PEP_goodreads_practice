using eShelves.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace eShelves
{
    public class ImageConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is HubPageViewModel.ProfileInfo.BookInfo)
            {
                MemoryStream ms = new MemoryStream(((HubPageViewModel.ProfileInfo.BookInfo)value).Slika);

                BitmapImage image = new BitmapImage();

                image.SetSourceAsync(ms.AsRandomAccessStream());

                return image;
            }
            else if(value is KnjigaDetaljiViewModel)
            {
                MemoryStream ms = new MemoryStream(((KnjigaDetaljiViewModel)value).Slika);

                BitmapImage image = new BitmapImage();

                image.SetSourceAsync(ms.AsRandomAccessStream());

                return image;
            }
            else if (value is OcjenaDetaljiViewModel.KnjigaInfo)
            {
                MemoryStream ms = new MemoryStream(((OcjenaDetaljiViewModel.KnjigaInfo)value).Slika);

                BitmapImage image = new BitmapImage();

                image.SetSourceAsync(ms.AsRandomAccessStream());

                return image;
            }
            else if (value is PolicaDetaljiViewModel.KnjigaInfo)
            {
                if (((PolicaDetaljiViewModel.KnjigaInfo)value).Slika != null)
                {
                    MemoryStream ms = new MemoryStream(((PolicaDetaljiViewModel.KnjigaInfo)value).Slika);

                    BitmapImage image = new BitmapImage();

                    image.SetSourceAsync(ms.AsRandomAccessStream());

                    return image;
                }

                return null;
            }
            else if(value is KnjigaVM)
            {
                if (((KnjigaVM)value).Slika != null)
                {
                    MemoryStream ms = new MemoryStream(((KnjigaVM)value).Slika);

                    BitmapImage image = new BitmapImage();

                    image.SetSourceAsync(ms.AsRandomAccessStream());

                    return image;
                }

                return null;
            }
            else if (value is HubPageViewModel.RecommendationsInfo.BookInfo)
            {
                if (((HubPageViewModel.RecommendationsInfo.BookInfo)value).Slika != null)
                {
                    MemoryStream ms = new MemoryStream(((HubPageViewModel.RecommendationsInfo.BookInfo)value).Slika);

                    BitmapImage image = new BitmapImage();

                    image.SetSourceAsync(ms.AsRandomAccessStream());

                    return image;
                }

                return null;
            }
            else if (value is HubPageViewModel.FeedInfo.FeedItemInfo)
            {
                if (((HubPageViewModel.FeedInfo.FeedItemInfo)value).Slika != null)
                {
                    MemoryStream ms = new MemoryStream(((HubPageViewModel.FeedInfo.FeedItemInfo)value).Slika);

                    BitmapImage image = new BitmapImage();

                    image.SetSourceAsync(ms.AsRandomAccessStream());

                    return image;
                }

                return null;
            }
            else
            {
                if (((AutorPageViewModel.KnjigaInfo)value).Slika != null)
                {
                    MemoryStream ms = new MemoryStream(((AutorPageViewModel.KnjigaInfo)value).Slika);

                    BitmapImage image = new BitmapImage();

                    image.SetSourceAsync(ms.AsRandomAccessStream());

                    return image;
                }

                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}
