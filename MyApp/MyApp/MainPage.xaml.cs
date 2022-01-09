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

        public void ButtonEvent(object s, EventArgs e) {
            Button sender = (s as Button);
            switch(B_cnt) {
                case 0:
                    sender.Text = "1st click!";
                    break;
                case 1:
                    sender.Text = "2nd click!";
                    break;
                case 2:
                    sender.Text = (sender is Button) ? "true" : "false";
                    break;
                case 3:
                case 4:
                    sender.Text = sender.ClassId;
                    break;
                default:
                    sender.Text = "Clicked";
                    break;
            }
            B_cnt++;
        }
    }
}
