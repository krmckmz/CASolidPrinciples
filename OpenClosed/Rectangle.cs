public class Rectangle : Shape 
{
    public double Length { get; set; }
    public double Height { get; set; }


    public double GetArea()
    {
        return (Length * Height);
    }
}