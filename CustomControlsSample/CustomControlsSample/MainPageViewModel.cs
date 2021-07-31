using MvvmHelpers;
using System;

namespace CustomControlsSample
{
   public class MainPageViewModel : BaseViewModel
   {
      DateTime startDateTime;
      public DateTime StartDateTime
      {
         get => startDateTime;
         set => SetProperty(ref startDateTime, value);
      }

      DateTime endDateTime;
      public DateTime EndDateTime
      {
         get => endDateTime;
         set => SetProperty(ref endDateTime, value);
      }

      string caption;
      public string Caption
      {
         get => caption;
         set => SetProperty(ref caption, value);
      }
   }
}
