namespace Tournament_manager
{
    public partial class RandomPage : ContentPage
    {
        public RandomPage()
        {
            InitializeComponent();
        }

        private async void OnGoToRootClicked(object sender, EventArgs e)
        {
            // Navigate back to the root page
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}