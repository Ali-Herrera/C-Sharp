using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
        //Console.WriteLine(Rect(2500,1500));
        //Console.WriteLine(Circle(375));
        //Console.WriteLine(Triangle(750,500));

        double TotalArea = (Rect(2500,1500) + (Circle(375)/2) + Triangle(750,500));
        //Console.WriteLine(TotalArea);

        double CostInPesos = TotalArea * 180;
        CostInPesos = Math.Round(CostInPesos, 2);
        Console.WriteLine($"The total cost for the materials to build this will be about {CostInPesos}");
        
    }
    static double Rect(double length, double width)
    {
       double area = (length*width);
       return area;
    }

    static double Circle(double radius)
    {
      double area = Math.PI * Math.Pow(radius, 2);
      return area;
    }

    static double Triangle (double bottom, double height)
    {
      double area = 0.5 * bottom * height;
      return area;
    }


  }
}
