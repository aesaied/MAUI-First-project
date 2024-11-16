namespace MauiSingleProject
{
    public partial class App : Application
    {

        Page tempPage = null;
        Page offlinePage = null;
        public App()
        {
            InitializeComponent();

            Connectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;

            tempPage= new AppShell();
         

            offlinePage=new NavigationPage( new  OfflinePage());


            MainPage = /*Connectivity.Current.NetworkAccess == NetworkAccess.Internet ? offlinePage :*/ tempPage;

           
        }

        private void Current_ConnectivityChanged(object? sender, ConnectivityChangedEventArgs e)
        {
            AppShell.Current.DisplayAlert("", Connectivity.NetworkAccess == NetworkAccess.None?"You are offline": "Connected!", "Ok");

           // MainPage = Connectivity.NetworkAccess == NetworkAccess.None ? offlinePage : tempPage;

        }
    }
}
