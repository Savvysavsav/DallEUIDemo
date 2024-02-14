using DallEUIDemo.Views;

namespace DallEUIDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DashboardView();
        }
    }
}

