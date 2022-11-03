public class AreaService
{
    public double CalculateArea(List<Shape> shapes)
    {
        double area = default(int);

        foreach (Shape shape in shapes)
            area += shape.GetArea();

        return area;
    }
}