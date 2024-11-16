namespace MauiSingleProject;

public partial class ControlsPage : ContentPage
{
	public ControlsPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		DisplayAlert("Hi", "Span Tapped!", "Ok");
    }
}