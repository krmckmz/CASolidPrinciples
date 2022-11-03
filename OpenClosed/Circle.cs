public class Circle : Shape
{
    public double Radius { get; set; }

    public double GetArea()
    {
        return (Radius * Radius * Math.Pi);
    }
}