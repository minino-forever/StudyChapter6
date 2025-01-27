namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Fun With Polymorphism******\n");

            Hexagon hex = new Hexagon("Beth");
            
            hex.Draw();

            Circle cir = new Circle("Cindy");

            cir.Draw();

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mikki"), new Circle("Beth"), new Hexagon("Linda") };

            foreach (Shape s in myShapes)
            {
                s.Draw();
            }

            Console.WriteLine("\n");

            ThreeDCircle o = new ThreeDCircle();

            o.Draw();

            ((Circle)o).Draw();
        }
    }
}
