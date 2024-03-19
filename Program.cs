namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Санни", 24);
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);

            var favcolors = new string[3];
            for(int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }
            Console.WriteLine("Мои любимые цвета: ");
            foreach (var fav in favcolors)
            {
                Console.WriteLine(fav);
            }

        }



        static string ShowColor(string name, int age)
        {
            Console.WriteLine($"{name}, {age} \nНапишите свой любимый цвет на английском с маленькой буквы");
            string color = Console.ReadLine();
            return color;
        }

    }
    
}