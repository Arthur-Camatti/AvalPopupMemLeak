using Avalonia.Controls;

namespace AvaloniaMemLeak.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        PART_footer_selectButton.Click += (_, _) => PART_footer_selectPopup.Open();
    }
}
