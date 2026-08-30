using KaiZStrap.UI.ViewModels.Settings;

namespace KaiZStrap.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for ShortcutsPage.xaml
    /// </summary>
    public partial class ShortcutsPage
    {
        public ShortcutsPage()
        {
            DataContext = new ShortcutsViewModel();
            InitializeComponent();
            App.FrostRPC?.SetPage("Shortcut");
        }
    }
}
