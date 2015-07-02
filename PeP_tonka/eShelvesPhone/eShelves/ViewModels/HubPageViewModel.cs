using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShelves.ViewModels
{
    public class HubPageViewModel
    {
        public HubPageViewModel()
        {
            Feed = new FeedInfo();
            BookShelves = new ShelvesInfo();
            Profile = new ProfileInfo();
            Recommendations = new RecommendationsInfo();
        }

        public HubPageViewModel(HubPageViewModel model)
        {
            Feed = new FeedInfo();
            BookShelves = new ShelvesInfo();
            Profile = new ProfileInfo();
            Recommendations = new RecommendationsInfo();
            Feed = model.Feed;
            BookShelves = model.BookShelves;
            Profile = model.Profile;
            Recommendations = model.Recommendations;
        }

        public FeedInfo Feed { get; set; }
        public ShelvesInfo BookShelves { get; set; }
        public ProfileInfo Profile { get; set; }
        public RecommendationsInfo Recommendations { get; set; }

        public class FeedInfo
        {
            public List<FeedItemInfo> FeedItems { get; set; }

            public class FeedItemInfo
            {
                public int FeedItemID { get; set; }
                public string EventDescription { get; set; }
                public string EventInformation { get; set; }
                public byte[] Slika { get; set; }
                public bool IsOcjena { get; set; }
                public int KnjigaID { get; set; }
                public int? OcjenaID { get; set; }
            }
        }

        public class ShelvesInfo
        {
            public List<ShelfInfo> Shelves { get; set; }

            public class ShelfInfo
            {
                public int ShelfID { get; set; }
                public string Naziv { get; set; }
                public int BookCount { get; set; }
                public int KorisnikID { get; set; }
            }
        }

        public class ProfileInfo
        {
            public int KorisnikID { get; set; }
            public string username { get; set; }
            public string Grad { get; set; }
            public DateTime Joined { get; set; }

            public bool IsFriend { get; set; }

            public int FriendCount { get; set; }

            public List<BookInfo> CurrentlyReadingBooks { get; set; }

            public class BookInfo
            {
                public int KnjigaID { get; set; }
                public string Naslov { get; set; }
                public string Autor { get; set; }
                public byte[] Slika { get; set; }
            }
        }

        public class RecommendationsInfo
        {
            public List<BookInfo> RecommendedBooks { get; set; }

            public class BookInfo
            {
                public int KnjigaID { get; set; }
                public string Naslov { get; set; }
                public string Autor { get; set; }
                public byte[] Slika { get; set; }
                public float ProsjecnaOcjena { get; set; }
            }
        }
    }
}
