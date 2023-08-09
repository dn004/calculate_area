using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {

    double mexico = Teotihuacan.areaOfTeotihuacan();
    double saudiArabia = MosqueOfMecca.areaOfMosqueOfMecca();
    double india = TajMahal.areaOfTajMahal();


    Console.WriteLine($"The Teotihucan Located in Mexico has an Area of {mexico}");
    Console.WriteLine($"The Great Mosque of Mecca Located in Saudi Arabia has an Area of {saudiArabia}");
    Console.WriteLine($"The Taj Mahal Located in India has an Area of {india}");
  }
  
}


public class Teotihuacan {
    static double triangle1(double bottom, double height) {
    return (.5 * bottom * height);
  }

  static double circle1 (double radius){
    return (Math.PI * Math.Pow(radius, 2));
  }

  static double rectangle1 (double length, double width){
    return(length * width);
  }

  public static double areaOfTeotihuacan(){
    
    double areaTriangle1 = triangle1(500,750);
    double areaCircle1 = circle1(375);
    double areaRectangle1 = rectangle1(1500,2500);

    return areaCircle1 + areaRectangle1 + areaTriangle1;

  }

}

public class MosqueOfMecca {
    static double triangle2(double bottom, double height) {
    return (.5 * bottom * height);
  }

    static double smallRectangle (double length, double width){
    return (length * width);
  }

    static double largeRectangle (double length, double width){
    return(length * width);
  }

    public static double areaOfMosqueOfMecca(){
    
    double areatriangle2 = triangle2(84,264);
    double areaSmallRectangle = smallRectangle(180,106);
    double areaLargeRectangle = largeRectangle(284,264);

    return (areaLargeRectangle - areatriangle2) + areaSmallRectangle;

  }

}



public class TajMahal {
    static double triangles(double bottom, double height) {
    return (.5 * bottom * height) * 4;
  }

    static double square (double side){
    return (side * side);
  }

    public static double areaOfTajMahal(){
    
    double areatriangles = triangles(24,24);
    double areasquare = square(90.5);

    return (areasquare - areatriangles);

  }

}
}