using KaiZStrap.UI.ViewModels.AccountManagers;

namespace KaiZStrap.UI.Elements.AccountManagers.Pages
{
    public partial class AccountsPage
    {
        private AccountsViewModel? _viewModel;

        public AccountsPage()
        {
            DataContext = new AccountsViewModel();
            InitializeComponent();
            _viewModel = DataContext as AccountsViewModel;
        }
    }
}