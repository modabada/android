using Xamarin.Forms;

namespace MyApp.View {
    public partial class ColorListPage: ContentPage {
        public ColorListPage() {
            DataTemplate dataTemplate = new DataTemplate(() => {
                BoxView boxView = new BoxView {
                    HeightRequest = 32,
                    WidthRequest = 32,
                    VerticalOptions = LayoutOptions.Center
                };
                boxView.SetBinding(BoxView.ColorProperty, "Color");

                Label label = new Label {
                    FontSize = 24,
                    VerticalOptions = LayoutOptions.Center
                };
                label.SetBinding(Label.TextProperty, "FriendlyName");

                StackLayout horizontalStackLayout = new StackLayout {
                    Orientation = StackOrientation.Horizontal,
                    Children = { boxView, label }
                };
                return horizontalStackLayout;
            });

            StackLayout stackLayout = new StackLayout();
            BindableLayout.SetItemTemplate(stackLayout, dataTemplate);

            ScrollView scrollView = new ScrollView { Content = stackLayout };

            Title = "ScrollView demo";
            Content = scrollView;
        }
    }
}