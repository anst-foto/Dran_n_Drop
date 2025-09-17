using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Dran_n_Drop;

public class MainWindowViewModel : ViewModelBase
{
    private bool _isRectangle;
    public bool IsRectangle
    {
        get => _isRectangle; 
        set => SetField(ref _isRectangle, value);
    }
    
    private bool _isEllipse;
    public bool IsEllipse
    {
        get => _isEllipse; 
        set => SetField(ref _isEllipse, value);
    }
    
    private SolidColorBrush _colorRectangle;
    public SolidColorBrush ColorRectangle
    {
        get => _colorRectangle;
        set => SetField(ref _colorRectangle, value);
    }
    
    private SolidColorBrush _colorEllipse;
    public SolidColorBrush ColorEllipse
    {
        get => _colorEllipse;
        set => SetField(ref _colorEllipse, value);
    }
    
    public ObservableCollection<SolidColorBrush> ListOfColors { get; set; } = 
    [
        new SolidColorBrush(Colors.Red),
        new SolidColorBrush(Colors.Green),
        new SolidColorBrush(Colors.Blue)
    ];
    
    private SolidColorBrush _selectedColor;

    public SolidColorBrush SelectedColor
    {
        get => _selectedColor;
        set
        {
            var result = SetField(ref _selectedColor, value);
            if (!result) return;

            if (IsRectangle)
            {
                ColorRectangle = value;
            }

            if (IsEllipse)
            {
                ColorEllipse = value;
            }
        } 
    }
}