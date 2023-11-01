using LessonMVVM.ViewModels.WindowViewModels;
using System.Windows;
using System.Windows.Navigation;

namespace LessonMVVM.Views.Windows;
public partial class MainView : NavigationWindow
{
    public MainView()
    {
        InitializeComponent();
        // DataContext = new MainViewModel();
    }
}
