using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace Horoscope.ViewModels;
public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    DateTimeOffset? _selectedDate;

    [ObservableProperty]
    string? _age;

    [ObservableProperty]
    string? _zodiacSign;

    public MainViewModel()
    { }

    [RelayCommand]
    public void Calculate()
    {
        CalculateAge();
        CalculateZodiacSign();
    }


    private void CalculateZodiacSign()
    {
        if (SelectedDate is not null)
        {
            var date = SelectedDate.Value.Date;
            var birthday = date.Month * 100 + date.Day;

            ZodiacSign = birthday switch
            {
                >= 120 and <= 218 => "ACUARIO",
                >= 219 and <= 329 => "PISCIS",
                >= 321 and <= 419 => "ARIES",
                >= 420 and <= 520 => "TAURO",
                >= 421 and <= 620 => "GEMINIS",
                >= 621 and <= 722 => "CANCER",
                >= 723 and <= 822 => "LEO",
                >= 823 and <= 922 => "VIRGO",
                >= 923 and <= 1022 => "LIBRA",
                >= 1023 and <= 1121 => "ESCORPIO",
                >= 1122 and <= 1221 => "SAGITARIO",
                _ => "CAPRICORNIO",
            };
        }
    }

    private void CalculateAge()
    {
        if (SelectedDate is not null)
        {
            var date = SelectedDate.Value.Date;
            var birthday = date.Year * 10000 + date.Month * 100 + date.Day;
            var dateNow = DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day;

            Age = ((dateNow - birthday) / 10000).ToString();
        }
    }

    [RelayCommand]
    public void Clear()
    {
        SelectedDate = null;
        Age = null;
        ZodiacSign = null;
    }
}
