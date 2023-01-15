using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SeathernyShopMAUI.Models;


namespace SeathernyShopMAUI.ViewModels;

public partial class MyCocktailViewModel : ObservableObject
{
    [ObservableProperty]
    List<Cocktail> cocktails;
    [ObservableProperty]
    bool isRefreshing;
    public MyCocktailViewModel()
    {
        LoadCocktailsAsync();

    }
    [RelayCommand]
 public async Task LoadCocktailsAsync()
    {
        try
        {
            await Task.Delay(2000);
            Cocktails = new()
        {
            new Cocktail(
                Name: "Cosmopolitan",
                Description: "Do you like cranberries and haven't tried any cocktails?🍹 Join us with the best Cosmopolitan😋",
                StartDateTime: DateTime.UtcNow.AddDays(1),
                EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(2),
                Image: new Uri("https://i.pinimg.com/564x/27/60/29/27602990f16926906f3549c551433c45.jpg"),
                Savory: new List<string> { "Cranberry", "Vodka", "Lime juice"},
                Sweet: new List<string> {"Acholic cocktail"}),
            new Cocktail(
                Name: "Paloma Fizz",
                Description: "A little red doesn't hurt🍓🤤 ",
                StartDateTime: DateTime.UtcNow,
                EndDateTime: DateTime.UtcNow.AddHours(2),
                Image: new Uri("https://i.pinimg.com/564x/e1/75/0a/e1750ab8277874de6290a24e7f20f713.jpg"),
                Savory: new List<string> { "Strawberry", "Ice", "Mint"},
                Sweet: new List<string> {"NonAcholic cocktail"})



        };

        }
      
        finally
        {
            IsRefreshing = false;
                }
    }

}
