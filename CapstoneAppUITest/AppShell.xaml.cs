using CapstoneAppUITest.Views;
namespace CapstoneAppUITest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void resetColor()
        {
         homePageButton.BackgroundColor = Colors.Black;
         memberListPageButton.BackgroundColor = Colors.Black;
         promoPageButton.BackgroundColor = Colors.Black;
         notificationPageButton.BackgroundColor = Colors.Black;
         adminControlPageButton.BackgroundColor = Colors.Black;        
        }

        private void resetPage()
        {
         homePageOpened.IsVisible = false;
         memberListPageOpened.IsVisible = false;
         promoPageOpened.IsVisible = false;
         notificationPageOpened.IsVisible = false;
         adminControlPageOpened.IsVisible = false;
        }

        private async void homePageButtonTapped(object sender, TappedEventArgs e)
        {  
         resetColor();
         resetPage();
         homePageButton.BackgroundColor = Color.FromArgb("#171717");
         homePageOpened.IsVisible = true;
         await Shell.Current.GoToAsync("//Page1");
        }

        private async void memberListPageButtonTapped(object sender, TappedEventArgs e)
        {
         resetColor();
         resetPage();
	     memberListPageButton.BackgroundColor = Color.FromArgb("#171717");
         memberListPageOpened.IsVisible = true;
         await Shell.Current.GoToAsync("//Page2");
        }

        private async void promoPageButtonTapped(object sender, TappedEventArgs e) //bago lang
        {
         resetColor();
         resetPage();
	     promoPageButton.BackgroundColor = Color.FromArgb("#171717");
         promoPageOpened.IsVisible = true;
         await Shell.Current.GoToAsync("//Page5");
        }

        private async void notificationPageButtonTapped(object sender, TappedEventArgs e)
        {
         resetColor();
         resetPage();
	     notificationPageButton.BackgroundColor = Color.FromArgb("#171717");
         notificationPageOpened.IsVisible = true;
         await Shell.Current.GoToAsync("//Page3");
        }

        private async void adminControlPageButtonTapped(object sender, TappedEventArgs e)
        {
         resetColor();
         resetPage();
	     adminControlPageButton.BackgroundColor = Color.FromArgb("#171717");
         adminControlPageOpened.IsVisible = true;
         await Shell.Current.GoToAsync("//Page4");
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
         await Shell.Current.GoToAsync("//Test");
        }
    }
}