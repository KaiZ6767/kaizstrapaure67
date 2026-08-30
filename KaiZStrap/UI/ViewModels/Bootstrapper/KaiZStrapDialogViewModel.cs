using System.Windows.Media;
using Wpf.Ui.Appearance;

namespace KaiZStrap.UI.ViewModels.Bootstrapper
{
    public class KaiZStrapDialogViewModel : BootstrapperDialogViewModel
    {
        public BackgroundType WindowBackdropType { get; set; } = BackgroundType.Mica;

        public SolidColorBrush BackgroundColourBrush { get; set; } = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));

        public KaiZStrapDialogViewModel(IBootstrapperDialog dialog) : base(dialog)
        {
        }
    }
}