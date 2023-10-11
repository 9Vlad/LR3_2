using System;

class Parent
{
    protected double Pole1;
    protected double Pole2;

    public Parent()
    {
        Pole1 = 0;
        Pole2 = 0;
    }

    public Parent(double pole1, double pole2)
    {
        Pole1 = pole1;
        Pole2 = pole2;
    }

    public void Print()
    {
        Console.WriteLine($"Довжина першої сторони: {Pole1}");
        Console.WriteLine($"Довжина другої сторони: {Pole2}");
    }

    public double Metod1()
    {
        return Pole1 * Pole2;
    }

    public double Metod2()
    {
        return 2 * (Pole1 + Pole2);
    }
}

class Child : Parent
{
    public Child(double side) : base(side, side)
    {
    }

    public double Metod3()
    {
        double radius = Math.Sqrt(Math.Pow(Pole1 / 2, 2) + Math.Pow(Pole2 / 2, 2));
        return Math.PI * Math.Pow(radius, 2);
    }

    public double Metod4()
    {
        double radius = Math.Sqrt(Math.Pow(Pole1 / 2, 2) + Math.Pow(Pole2 / 2, 2));
        return 2 * Math.PI * radius;
    }
}

class Program
{
    static void Main()
    {
        Random rand = new Random();

        for (int i = 0; i < 5; i++)
        {
            double side1 = rand.Next(1, 10); // Генеруємо випадкову довжину сторони 1
            double side2 = rand.Next(1, 10); // Генеруємо випадкову довжину сторони 2

            if (side1 != side2) // Якщо сторони різні (прямокутник)
            {
                Parent rectangle = new Parent(side1, side2);
                Console.WriteLine("Прямокутник:");
                rectangle.Print();
                Console.WriteLine($"Площа: {rectangle.Metod1()}");
                Console.WriteLine($"Периметр: {rectangle.Metod2()}");
            }
            else // Якщо сторони однакові (квадрат)
            {
                Child square = new Child(side1);
                Console.WriteLine("Квадрат:");
                square.Print();
                Console.WriteLine($"Площа: {square.Metod1()}");
                Console.WriteLine($"Периметр: {square.Metod2()}");
                Console.WriteLine($"Площа описаного кола: {square.Metod3()}");
                Console.WriteLine($"Довжина описаного кола: {square.Metod4()}");
            }

            Console.WriteLine();
        }
    }
}