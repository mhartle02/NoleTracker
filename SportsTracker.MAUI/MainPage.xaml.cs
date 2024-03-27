namespace SportsTracker.MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void Enter_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//SportView");
        }
    }

}
