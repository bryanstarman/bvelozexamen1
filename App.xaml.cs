using bvelozexamen1.Vistas;

namespace bvelozexamen1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new login());
        }
    }
}