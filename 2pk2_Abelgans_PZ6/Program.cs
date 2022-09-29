namespace _2pk2_Abelgans_PZ6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            int y = 20;
            double x = 10.0;
            double r;
            do
            {
                i++;
                r = x * 0.1;
                x += r;
            }
            while (x <= y);
            Console.WriteLine(i);
        }
    }
}
