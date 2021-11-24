using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControlsSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Container : ContentView
    {
        public Container()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty HeaderTitleProperty =
           BindableProperty.Create("HeaderTitle", typeof(string), typeof(Container), "");

        public string HeaderTitle
        {
            get => (string)GetValue(HeaderTitleProperty);
            set => SetValue(HeaderTitleProperty, value);
        }

        public static readonly BindableProperty HeaderTitleIsVisibleProperty = BindableProperty.Create(
           "HeaderTitleIsVisible",
           typeof(bool),
           typeof(Container),
           true);

        public bool HeaderTitleIsVisible
        {
            get => (bool)GetValue(HeaderTitleIsVisibleProperty);
            set => SetValue(HeaderTitleIsVisibleProperty, value);
        }

        public static readonly BindableProperty IconProperty = BindableProperty.Create(
           "Icon",
           typeof(string),
           typeof(Container),
           string.Empty);

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly BindableProperty IconIsVisibleProperty = BindableProperty.Create(
           "IconIsVisible",
           typeof(bool),
           typeof(Container),
           false);

        public bool IconIsVisible
        {
            get => (bool)GetValue(IconIsVisibleProperty);
            set => SetValue(IconIsVisibleProperty, value);
        }

        public static readonly BindableProperty OnIconTappedCommandProperty = BindableProperty.Create(
           "OnIconTappedCommand",
           typeof(ICommand),
           typeof(Container));

        public ICommand OnIconTappedCommand
        {
            get => (ICommand)GetValue(OnIconTappedCommandProperty);
            set => SetValue(OnIconTappedCommandProperty, value);
        }
    }
}