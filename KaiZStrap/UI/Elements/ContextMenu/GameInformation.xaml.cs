using KaiZStrap.UI.ViewModels.ContextMenu;

namespace KaiZStrap.UI.Elements.ContextMenu
{
    /// <summary>
    /// Interaction logic for GameInformation.xaml
    /// </summary>
    public partial class GameInformation
    {
        public GameInformation(long placeId, long universeId)
        {
            DataContext = new GameInformationViewModel(placeId, universeId);
            InitializeComponent();
        }
    }
}