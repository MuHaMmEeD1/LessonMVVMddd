using LessonMVVM.ViewModels.PageViewModels;
using System.Windows.Controls;

namespace LessonMVVM.Views.Pages;
public partial class DashboardPageView : Page
{
    public DashboardPageView()
    {
        InitializeComponent();
        DataContext = new DashboardPageViewModel();
    }
}
