namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Dishes = new string[5];
            
            (string Name, string[] Dishes) User = ("Санни", Dishes);
            
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine($"Введите любимое блюда пользователя {User.Name} номер {i+1}");
                User.Dishes[i] = Console.ReadLine();
            }

        }
    }
}