using System.Runtime.InteropServices;

Queue<int> queue = new Queue<int>();

queue.Enqueue(1);
queue.Enqueue(5);

Console.WriteLine($"Is 5 in the Q?:{queue.Contains(5)}");

Console.WriteLine($"Removing:{queue.Dequeue()}");
Console.WriteLine($"Removing:{queue.Dequeue()}");

Console.WriteLine(queue);

foreach(int element in queue)
{
    Console.WriteLine(element);
}
