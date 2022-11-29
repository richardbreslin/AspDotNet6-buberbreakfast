using BuberBreakfast.Models;
namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    //Storing breakfasts in memory
    //This is where database implementation would go
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();

    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);

    }

    public void DeleteBreakfast(Guid id)
    {
        _breakfasts.Remove(id);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }

    public void UpsertBreakfast(Guid id, Breakfast breakfast)
    {
        _breakfasts[breakfast.Id] = breakfast;
    }
}