using KaiZStrap.UI.Elements.Base;
using KaiZStrap.UI.ViewModels.Dialogs;

namespace KaiZStrap.UI.Elements.Dialogs
{
    public partial class ManualCookieDialog : WpfUiWindow
    {
        public ManualCookieDialogViewModel ViewModel { get; }

        public ManualCookieDialog()
        {
            ViewModel = new ManualCookieDialogViewModel(this);
            DataContext = ViewModel;

            InitializeComponent();
        }
    }
}