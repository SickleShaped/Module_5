namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("укажите число");
            var N = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Укажите степень");
            var pow = Byte.Parse(Console.ReadLine());

            int result = PowerUp(N, pow) ;
            Console.WriteLine(result);

            Console.ReadKey();

        }

        private static int PowerUp(int N, byte pow)
        {
            int result = 0;
            if (pow == 0)
            {
                result = 1;
            }
            else
            {

                if (pow == 1)
                {
                    return N;

                }
                else
                {
                    result = PowerUp(N, (byte)(pow - 1))*N;

                }
            }

            return result;

        }

    }
    
}