namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetArrayFromConsole(10);
            ShowArray(array);

        }

        static int[] GetArrayFromConsole(int num = 3)
        {
            int[] array = new int[num];
            
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

        static void ShowArray(int[] array, bool isSort = false)
        {
            if (isSort==false)
            {
                array = SortArray(array);
            }
            foreach (var a in array)
            {
                Console.Write(a + " ");
            }
        }

    }
    
}