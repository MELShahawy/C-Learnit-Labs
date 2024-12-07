internal class Program
{
    private static void Main(string[] args)
    {
        #region Array
        #region create array
        int min = 0;
        int max = 0;
        int[] array1 = new int[6];
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("Enter A num: ");
            min = array1[0];
            max = array1[0];
            array1[i] = int.Parse(Console.ReadLine());
            min = array1[0];
            max = array1[0];
        }
        #endregion
        #region Find MIN & MAX
        for (int i = 0; i < array1.Length; i++)
        {
            if (min > array1[i]) { min = array1[i]; }
            if (max < array1[i]) { max = array1[i]; }
        }


        Console.WriteLine($"the MINIMUM IS {min}");
        Console.WriteLine($"the MAXIMUM IS {max}");
        #endregion
        #region SORTING

        int[] array2 = new int[6];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = array1[i];
        }
        int temp = 0;

        for (int i = 0; i < array2.Length; i++)            // for some reason it works but for the first item which is very weird!!! think about it later!
            /// STILL NEEDS WORK..
        {
            if (i != 5)
            {
                if (array2[i] > array2[i + 1])
                {
                    Console.WriteLine($"current i is {i}");
                    temp = array2[i + 1]; ;
                    array2[i + 1] = array2[i];
                    array2[i] = temp;
                    i = 0;


                }
            }

        }

        Console.WriteLine("after Sorting");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }

        #endregion
        #endregion
    }
}