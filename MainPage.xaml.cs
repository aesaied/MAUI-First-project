namespace MauiSingleProject
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
          await  Shell.Current.GoToAsync(nameof(CalcPage));

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TestStack));


        }

        private async void btnControls_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ControlsPage));

        }

        private async void btnImagePicker(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TestFilePicker));

        }

        private async void btnAbsoulte_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TestAbsolute));

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await myScroll.ScrollToAsync(hLayout, ScrollToPosition.Center, true);
        }
    }

}
