using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControlsSample
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class CustomDateTimePicker : ContentView
   {
      DatePicker myDatePicker;
      TimePicker myTimePicker;

      public CustomDateTimePicker()
      {
         InitializeComponent();
      }

      // https://dotnetdevaddict.co.za/2020/08/16/templated-controls-in-xamarin-forms/
      protected override void OnApplyTemplate()
      {
         base.OnApplyTemplate();

         myDatePicker = (DatePicker)GetTemplateChild("MyDatePicker");
         myTimePicker = (TimePicker)GetTemplateChild("MyTimePicker");
      }

      public static readonly BindableProperty CaptionProperty = BindableProperty.Create("Caption", typeof(string), typeof(CustomDateTimePicker), "");

      public string Caption
      {
         get => (string)GetValue(CaptionProperty);
         set => SetValue(CaptionProperty, value);
      }

      public static readonly BindableProperty SelectedDateTimeProperty = BindableProperty.Create(
         "SelectedDateTime",
         typeof(DateTime),
         typeof(CustomDateTimePicker),
         null,
         propertyChanged: OnPropertyChanged);

      static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
      {
         if (newValue != oldValue)
         {
            var customDateTimePicker = bindable as CustomDateTimePicker;
            customDateTimePicker?.SetControlValues((DateTime)newValue);
         }
      }

      public DateTime SelectedDateTime
      {
         get => (DateTime)GetValue(SelectedDateTimeProperty);
         // The setter is not called when the binded property change
         // Need to handle it on the backing property (OnPropertyChanged)
         // It is used when the controls are changed by the user
         set => SetValue(SelectedDateTimeProperty, value);
      }

      public void SetControlValues(DateTime dateTimeToSet)
      {
         myDatePicker.Date = dateTimeToSet.Date;
         myTimePicker.Time = dateTimeToSet.TimeOfDay;
      }

      void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
      {
         if (e.NewDate != e.OldDate)
         {
            SelectedDateTime = e.NewDate.Add(SelectedDateTime.TimeOfDay);
         }
      }

      void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
      {
         var timePicker = sender as TimePicker;
         if (timePicker != null && e.PropertyName == "Time" && timePicker.Time != SelectedDateTime.TimeOfDay)
         {
            SelectedDateTime = SelectedDateTime.Date.Add(timePicker.Time);
         }
      }
   }
}