namespace quick_sort;

class Program
{
    static void Main(string[] args)
    {
        
    }

    internal static void QuickSort(IList<int> list, int i, int j)
    {
        int pivot = Partition(list, i, j);
        QuickSort(list, i, pivot);
        QuickSort(list, pivot + 1, j);
        
        
    }

    private static int Partition(IList<int> list, int i, int j)
    {
        var pivot = i;
        var s1_index = i;
        var s2_index = i;
        for (var k = i + 1; k < j; j++)
        {
            if (list[k] >= list[pivot])
            {
                s2_index++;
            }
            else
            {
                s1_index++;
                
                var tmp = list[s1_index];
                list[s1_index] = list[k];
                list[k] = tmp;

                s2_index++;
            }
        }
        var q = list[pivot];
        list[pivot] = list[s1_index];
        list[s1_index] = q;
        return s1_index;
    }   
}