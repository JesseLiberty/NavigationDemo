using Xamarin.Forms;

namespace NavigationDemo {
   public partial class NavigationDemoPage : ContentPage {
      public NavigationDemoPage() {
         InitializeComponent();
      }

      void Handle_Clicked( object sender,System.EventArgs e ) {
         int someValue = 35;
         Navigation.PushAsync( new Page2( someValue ) );
      }
   }
}
