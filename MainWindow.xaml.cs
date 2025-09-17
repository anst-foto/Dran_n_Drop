using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Dran_n_Drop;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void _MouseDown(object sender, MouseButtonEventArgs e)
    {
        var block = (TextBlock)sender;
        DragDrop.DoDragDrop(block, block.Background, DragDropEffects.Copy);
    }

    private void _Drop(object sender, DragEventArgs e)
    {
        var shape = sender as Shape;
        var brush = e.Data.GetData(typeof(SolidColorBrush));
        shape.Fill = brush as Brush;
    }
}