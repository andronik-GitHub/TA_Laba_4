using System;
using System.Drawing;
using System.Reflection;
using System.Text;

class DirectMergeSort<T> where T : IComparable<T>
{
    static void Merge(T[] array, int lowIndex, int middleIndex, int highIndex)
    {
        var left = lowIndex;
        var right = middleIndex + 1;
        var tempArray = new T[highIndex - lowIndex + 1];
        var index = 0;

        while ((left <= middleIndex) && (right <= highIndex))
        {
            if (array[left].CompareTo(array[right]) < 0)
            {
                tempArray[index] = array[left];
                left++;
            }
            else
            {
                tempArray[index] = array[right];
                right++;
            }

            index++;
        }

        for (var i = left; i <= middleIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = right; i <= highIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = 0; i < tempArray.Length; i++)
            array[lowIndex + i] = tempArray[i];
    }

    static T[] MergeSort(T[] array, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            var middleIndex = (lowIndex + highIndex) / 2;
            MergeSort(array, lowIndex, middleIndex);
            MergeSort(array, middleIndex + 1, highIndex);
            Merge(array, lowIndex, middleIndex, highIndex);
        }

        return array;
    }

    public static T[] MergeSort(T[] array)
    {
        return MergeSort(array, 0, array.Length - 1);
    }
}
