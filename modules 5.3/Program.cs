
namespace modules_5._3
{
    internal class Program
    {
        static int num1 = 667;
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            Echo(str, 5);
        }
        

        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
                Console.WriteLine("..." + modif);
                if (deep > 1)
                {
                    Echo(modif, deep - 1);
                }
            }
        }
    }
}