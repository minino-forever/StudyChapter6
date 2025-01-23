namespace BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Basic Inheritance*****\n");

            Car myCar = new Car(80) { Speed = 50 };

            Console.WriteLine($"My car is going {myCar.Speed} mph");

            Console.WriteLine();

            MiniVan myVan = new MiniVan { Speed = 10 };

            Console.WriteLine($"My van is going {myVan.Speed} mph");

        }
    }
}
