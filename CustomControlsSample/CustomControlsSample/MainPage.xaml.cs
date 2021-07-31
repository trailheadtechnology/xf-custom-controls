using System;
using Xamarin.Forms;

namespace CustomControlsSample
{
   public partial class MainPage : ContentPage
   {
      public MainPage()
      {
         InitializeComponent();

         BindingContext = new MainPageViewModel
         {
            StartDateTime = new DateTime(2020, 12, 15, 20, 35, 0),
            EndDateTime = new DateTime(2020, 12, 16, 19, 35, 0)
         };
      }
   }
}
