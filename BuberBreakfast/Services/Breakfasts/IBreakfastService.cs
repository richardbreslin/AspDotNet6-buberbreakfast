namespace BuberBreakfast.Services.Breakfasts;
using BuberBreakfast.Models;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    Breakfast GetBreakfast(Guid id);

    void UpsertBreakfast(Guid id, Breakfast breakfast);

    void DeleteBreakfast(Guid id);
}