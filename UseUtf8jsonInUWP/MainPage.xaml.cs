using DotNetStandardLib;
using Windows.UI.Xaml.Controls;

namespace UseUtf8jsonInUWP
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Result.Text = TestSerialization.Serialize();
        }
    }
}
