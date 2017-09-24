using EcommerceJewel.Common;
using EcommerceJewel.DataModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace EcommerceJewel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyCartPage : Page
    {
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public MyCartPage()
        {
            InitializeComponent();
            var item = JewelryDataSource.MyCartItems;
            DefaultViewModel["Items"] = item;
        }

        /// <summary>
        /// Gets the DefaultViewModel. This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        private void CloseFlyout(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Popup)
                (this.Parent as Popup).IsOpen = false;
        }
    }
}
