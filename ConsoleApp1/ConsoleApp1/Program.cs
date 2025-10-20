using System.Numerics;

class Program
{
    static void bubbleSort(int[] array)
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
    static void QuickSort(int[] array)
    {
        if (array == null || array.Length <= 1) return;
        Sort(array, 0, array.Length - 1);
    }

    static void Sort(int[] array, int left, int right)
    {
        if (left >= right) return;

        int pivotIndex = Partition(array, left, right);

        Sort(array, left, pivotIndex - 1);
        Sort(array, pivotIndex + 1, right);
    }
    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right]; 
        int i = left - 1;         

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        (array[i + 1], array[right]) = (array[right], array[i + 1]);
        return i + 1;
    }

    static void Main()
    {
        int[] arr = { 10,6,3,432,76,7,1,4,5,6,678,9,3,3,1};
        QuickSort(arr);
        for (int i =0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

