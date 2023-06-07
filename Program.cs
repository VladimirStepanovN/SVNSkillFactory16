namespace SVNSkillFactory16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            Console.WriteLine($"цвет: {p.color}, стоимость: {p.cost}");
            Pen p2 = new Pen("Зелёный", 150);
            Console.WriteLine($"цвет: {p2.color}, стоимость: {p2.cost}");
        }
        class Pen
        {
            public string color;
            public int cost;
            public Pen()
            {
                color = "Черный";
                cost = 100;
            }
            public Pen(string color, int cost)
            {
                this.color = color;
                this.cost = cost;
            }
        }
    }
}