namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] favColors = new string[3];

            for (int i = 0; i < favColors.Length; i++)
            {
                favColors[i] = ShowColor(i);
                Console.WriteLine("Любимый цвет - "+favColors[i]);
            }

        }



        static string ShowColor(int iterator)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            string color = Console.ReadLine();

            return color;
        }

    }
    
}