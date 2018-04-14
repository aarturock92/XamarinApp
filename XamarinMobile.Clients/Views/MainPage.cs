using Xamarin.Forms;

namespace XamarinMobile.Clients.Views
{
    public class MainPagePrincipal: TabbedPage
    {
        public MainPagePrincipal()
        {
            Page mainPage, aboutPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    mainPage = new NavigationPage(new MainPage())
                    {
                        Title = "Main"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    };

                    mainPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";

                    break;
                default:
                    mainPage = new MainPage()
                    {
                        Title = "Menu Principal"
                    };

                    aboutPage = new AboutPage()
                    {
                        Title = "Información"
                    };

                    break;
            }

            Children.Add(mainPage);
            Children.Add(aboutPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
