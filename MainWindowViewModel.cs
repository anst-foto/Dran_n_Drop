using System.Collections.ObjectModel;
using System.Windows.Media;

namespace Dran_n_Drop;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<SolidColorBrush> ListOfColors { get; set; } = 
    [
        new SolidColorBrush(Colors.Red),
        new SolidColorBrush(Colors.Green),
        new SolidColorBrush(Colors.Blue)
    ];
}