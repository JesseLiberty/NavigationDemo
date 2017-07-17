using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationDemo {
   public partial class Page2 : ContentPage {
      public int TheValue { get; set; }

      public Page2( int aValue ) {
         TheValue = aValue;

         BindingContext = this;
         InitializeComponent();
      }
   }
}
