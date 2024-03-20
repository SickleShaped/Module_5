namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            int[] sorteddesk;
            int[] sortedask;
            int[] array = GetArrayFromConsole(ref number);
            SortArray(array, out sorteddesk, out sortedask);
            ///ShowArray(array);
            Console.WriteLine("");
            ShowArray(sorteddesk);
            Console.WriteLine("");
            ShowArray(sortedask);

        }

        static int[] GetArrayFromConsole(ref int num)
        {
            int[] array = new int[num];
            
            for(int i=0;i<array.Length; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            return array;
        }

        static void SortArray(in int[] array, out int[] sorteddesk, out int[] sortedask)
        {
            sorteddesk = SortArrayDesc(array);
            sortedask = SortArrayAsc(array);
        }

        static int[] SortArrayDesc(int[] array)
        {
            int[] sorteddesc = new int[array.Length];
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        sorteddesc[i] = array[i];
                        sorteddesc[j] = array[j];
                    }
                }
            }
            return sorteddesc;
        }

        static int[] SortArrayAsc(int[] array)
        {
            int[] sortedasc = new int[array.Length];
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        sortedasc[i] = array[i];
                        sortedasc[j] = array[j];
                    }
                }
            }
            return sortedasc;
        }

        static void ShowArray(int[] array)
        {

            foreach (var a in array)
            {
                Console.Write(a + " ");
            }
        }

    }
    
}