using MvvmHelpers;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace CustomControlsSample
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            CleanDate = new Command(OnCleanDate);
        }

        void OnCleanDate()
        {
            StartDateTime = DateTime.MinValue;
            EndDateTime = DateTime.MinValue;
        }

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

        public ICommand CleanDate { get; private set; }
    }
}
