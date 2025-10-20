using System.Numerics;

class Program
{
    static void functionSorting(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
    static void Main()
    {
        int[] arr = { 3,7,5};
        functionSorting(arr);
        for (int i =0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

