using System;

class Laba_4
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int[] intArr = new int[N];
        Random r = new();
        for (int i = 0; i < N; i++) intArr[i] = r.Next(-100, 100);

        Console.WriteLine(string.Join(" ", intArr) + "\n");
        DirectMergeSort<int>.MergeSort(intArr);
        Console.WriteLine(string.Join(" ", intArr));



        char[] arr;
        string temp;

        temp = Console.ReadLine();
        temp = "afdfabcabcadefdea";

        arr = temp.ToCharArray();

        Console.WriteLine("\n\n\n\n" + string.Join("", arr));
        DirectMergeSort<char>.MergeSort(arr);
        Console.WriteLine(string.Join("", arr));



        Console.ReadKey();
    }
    
}