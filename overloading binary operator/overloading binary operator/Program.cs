using System;

class Point
{
    public int x, y;

    // Constructor
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // Overloading the + operator
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.x + p2.x, p1.y + p2.y);
    }

    // Display method
    public void Show()
    {
        Console.WriteLine($"x = {x}, y = {y}");
    }
}

class Program
{
    static void Main()
    {
        Point point1 = new Point(3, 4);
        Point point2 = new Point(5, 7);

        Point result = point1 + point2;  // Using overloaded +

        Console.WriteLine("Result of adding two points:");
        result.Show();  // Output: x = 8, y = 11
    }
}
