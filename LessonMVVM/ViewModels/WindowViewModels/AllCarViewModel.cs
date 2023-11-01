using LessonMVVM.Models;
using System.Collections.ObjectModel;

namespace LessonMVVM.ViewModels.WindowViewModels;

public class AllCarViewModel
{
    public ObservableCollection<Car> Cars{ get; set; }

    public AllCarViewModel(ObservableCollection<Car> cars)
    {
        Cars = cars;
    }

    public AllCarViewModel()
    {
        Cars = new();
    }

}
