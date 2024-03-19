namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetArrayFromConsole();
            SortArray(array);
            foreach(var a in array)
            {
                Console.Write(a + " ");
            }
        }



        static int[] GetArrayFromConsole()
        {
            int[] array = new int[3];
            
            for(int i=0;i<array.Length; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            return array;
        }

        static int[] SortArray(int[] array)
        {
            int temp;
            for(int i=0;i<array.Length;i++)
            {
                for(int j=0;j<array.Length;j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

    }
    
}