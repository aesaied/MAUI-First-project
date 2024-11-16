namespace MauiSingleProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CalcPage),typeof(CalcPage));
            Routing.RegisterRoute(nameof(TestStack), typeof(TestStack));
            Routing.RegisterRoute(nameof(ControlsPage), typeof(ControlsPage));
            Routing.RegisterRoute(nameof(TestFilePicker), typeof(TestFilePicker));
            Routing.RegisterRoute(nameof(TestAbsolute), typeof(TestAbsolute));




        }
    }
}
