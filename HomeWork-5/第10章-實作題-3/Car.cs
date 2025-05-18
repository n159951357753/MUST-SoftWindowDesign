public class Car : IPrice
{
    public double Price { get; set; }
    public string Name { get; set; }

    public Car(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public double GetPrice()
    {
        return Price;
    }

    public string GetName()
    {
        return Name;
    }
}
