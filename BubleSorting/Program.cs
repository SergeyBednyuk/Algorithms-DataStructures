namespace BubleSorting;

class Program
{
    static void Main(string[] args)
    {
        var case1 = new int[] { 29, 10, 14, 37, 13 };
        var result = BubleSort(case1);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    static IEnumerable<int> BubleSort(IList<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 1; j < numbers.Count - i; j++)
            {
                if (numbers[j] < numbers[j - 1])
                {
                    var tmp = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = tmp;
                }
            }
        }
        return numbers;
    }
}