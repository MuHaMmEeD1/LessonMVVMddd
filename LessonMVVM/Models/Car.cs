using LessonMVVM.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace LessonMVVM.Models;

public class Car : NotificationService
{
    private string? make;
    private string? model;
    private DateTime? date;

    public string? Make { get => make; set { make = value; OnPropertyChanged(); } }
    public string? Model { get => model; set { model = value; OnPropertyChanged(); } }
    public DateTime? Date { get => date; set { date = value; OnPropertyChanged(); } }

    public Car()
    {
        Make = "";
        Model = "";
        Date = null;
    }

    public Car(string? make, string? model, DateTime? date)
    {
        Make = make;
        Model = model;
        Date = date;
    }

    public override string ToString() => $"{Make} - {Model} - {Date}";
}
