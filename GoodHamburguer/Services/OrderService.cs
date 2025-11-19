using GoodHamburguer.Models;

public class OrderService
{
    public Order CurrentOrder { get; private set; } = new();

    public event Action? onChange;

    public void AddDish(Dish dish)
    {
        try
        {
            CurrentOrder.AddDish(dish);
            NotifyStateChanged();
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(ex.Message);
        }
    }

    public void ClearOrder()
    {
        CurrentOrder = new Order();
        NotifyStateChanged();
    }

    public void NotifyStateChanged() => onChange?.Invoke();
}