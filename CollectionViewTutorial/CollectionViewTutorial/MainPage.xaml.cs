using System.Collections.Generic;
using Xamarin.Forms;

namespace CollectionViewTutorial
{
    public partial class MainPage : ContentPage
    {
        public IList<Cat> Cats { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            Cats = new List<Cat>();
            Cats.Add(new Cat
            {
                Name = "Serengetimale Cat",
                Location = "United States",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1a/Serengetimalecat.jpg"
            });

            Cats.Add(new Cat
            {
                Name = "Snowshoe",
                Location = "United States",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4b/Snowshoe_%28cat%29.JPG"
            });

            Cats.Add(new Cat
            {
                Name = "Russian Blue",
                Location = "Russia",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5f/Russian_Blue_001.gif"
            });

            Cats.Add(new Cat
            {
                Name = "Abyssinian",
                Location = "Ethiopia",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9b/Gustav_chocolate.jpg"
            });

            Cats.Add(new Cat
            {
                Name = "Bambino",
                Location = "United States",
                ImageUrl = "https://www.petguide.com/wp-content/uploads/2017/09/bambino-cat-1.jpg"
            });

            BindingContext = this;
        }

        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cat selectedItem = e.CurrentSelection[0] as Cat;
        }
    }
}