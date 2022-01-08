using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyApp {
    public partial class MainPage: ContentPage {
        int B_cnt = 0;
        public MainPage() {
            InitializeComponent();
        }

        public void ButtonEvent(object sender, EventArgs e) {
            switch(B_cnt) {
                case 0:
                    (sender as Button).Text = "1st click!";
                    break;
                case 1:
                    ((Button) (sender)).Text = "2nd click!";
                    break;
                case 2:
                    (sender as Button).Text = (sender is Button) ? "true" : "false";
                    break;
                default:
                    (sender as Button).Text = "Clicked";
                    break;
            }
            B_cnt++;
        }
    }
}
