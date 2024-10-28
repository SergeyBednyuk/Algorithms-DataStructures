namespace ConsoleApp1Queue;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(2); // 2
        queue.Enqueue(3); // 2, 3
        Console.WriteLine(queue.Peek()); // 2
        queue.Dequeue(); // 3
        Console.WriteLine(queue.Peek()); // 3
        queue.Enqueue(4); // 3, 4
        queue.Enqueue(5); // 3, 4, 5
        queue.Enqueue(6); // 3, 4, 5, 6
        queue.Dequeue();
        Console.WriteLine(queue.Peek()); // 6
        for (int i = 0; i < queue.Count; i++)
        {
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
        }
        Console.ReadKey();
    }
}