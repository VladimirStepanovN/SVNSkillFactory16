namespace SVNSkillFactory16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine($"a: {r1.a}, b: {r1.b}");
            Rectangle r2 = new Rectangle(5);
            Console.WriteLine($"a: {r2.a}, b: {r2.b}");
            Rectangle r3 = new Rectangle(10, 20);
            Console.WriteLine($"a: {r3.a}, b: {r3.b}");
        }
        class Rectangle
        {
            public int a;
            public int b;
            public Rectangle()
            {
                a = 6;
                b = 4;
            }
            public Rectangle(int one)
            {
                a = one;
                b = one;
            }
            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public int Square()
            {
                return a * b;
            }
        }
    }
}