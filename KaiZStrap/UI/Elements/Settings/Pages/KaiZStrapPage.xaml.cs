using KaiZStrap.UI.ViewModels.Settings;

namespace KaiZStrap.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for KaiZStrapPage.xaml
    /// </summary>
    public partial class KaiZStrapPage
    {
        public KaiZStrapPage()
        {
            DataContext = new KaiZStrapViewModel();
            InitializeComponent();
        }
    }
}