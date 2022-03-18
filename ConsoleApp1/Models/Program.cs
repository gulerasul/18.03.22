using ConsoleApp1;
using System;

namespace ConsoleApp1
{
    class Program

         //İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
         //İstifadəçi 2 yazıb enter-ə click-ləsə Rectangular-in CalcArea methodu işə düşməlidir.
         //İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdı.
    {
        private static int key;

        static void Main(string[] args)
        {
            Rectangular rec = new Rectangular(5,6);
            Square sq = new Square(7);
            do
            {
                switch (key)
                {
                    case 1:
                        Console.WriteLine("1ci method ");

                        sq.CalcArea();

                        break;

                    case 2:
                        Console.WriteLine("2ci method");

                        rec.CalcArea();
                        break;


                    case 3:
                        Console.WriteLine("3cu method");
                        break;
                }

                

            } while (true);   
        }
    } 
         abstract class Figure
    {
        public abstract void CalcArea();
    }

}
       class Square: Figure
    
{
    private int _side;
    public int side
    {
        get
        {
            return _side;
        }
        set
        {
            if (value>0)
            {
                _side = value;
            }
        }
    }

    public Square (int side)
    {
        this.side = side;
    }

    public Square()
    {
    }

    public override void CalcArea()
    {
        int S = side * side;
        Console.WriteLine($"Area of a square: {S}");
    }
}
     class Rectangular : Figure

{
    private int _width;

     
    public int width 
    {
        get
        {
            return _width;
        }
        set
        {
            if (value>0)
            {
                _width = value;
            }

        }
            }
    private int _lenght;   
    public int length  
    { 
        get
        {
            return _lenght;

        }
        set
        {
            if (value>0)
            {
                _lenght = value;


            }

        }
             }

    public Rectangular(int side, int v)
    {
        this.width = width;
        this.length = length;
    }

    public override void CalcArea()
    {
        int S = length * width;
        Console.WriteLine($"Area of a Rectangular: {S}");
    }
}