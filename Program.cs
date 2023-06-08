namespace SVNSkillFactory16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bus.Load = 100; //если закомментировать, выведет что автобус пуст.
            bus.PrintStatus();
        }
        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if (Load.HasValue)
                {
                    Console.WriteLine("Количество пассажиров: {0}.", Load.Value);
                }
                else
                {
                    Console.WriteLine("Автобус пуст.");
                }
            }
        }
    }
}