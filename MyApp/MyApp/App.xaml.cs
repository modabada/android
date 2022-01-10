using Xamarin.Forms;

namespace MyApp {
    public partial class App: Application {
        public App() {
            InitializeComponent();

            MainPage = new MainPage();
            //MainPage = new View.ColorListPage();
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
