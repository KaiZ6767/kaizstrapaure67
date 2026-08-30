using KaiZStrap.UI.ViewModels.Dialogs;

namespace KaiZStrap.UI.Elements.Dialogs
{
    public partial class CommunityModInfoDialog
    {
        public CommunityModInfoViewModel ViewModel { get; }

        public CommunityModInfoDialog(CommunityMod mod)
        {
            InitializeComponent();
            ViewModel = new CommunityModInfoViewModel(mod, this);
            DataContext = ViewModel;
        }
    }
}