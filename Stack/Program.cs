// Node<int> node3 = new Node<int>(20);
// Node<int> node2 = new Node<int>(15, node3);
// Node<int> node1 = new Node<int>(10, node2);





// Console.WriteLine(node1);

Stack<int> stack = new Stack<int>();
Console.WriteLine(stack.Contains(10));
stack.Push(10);
stack.Push(100);
stack.Push(30);

// int[] stuff = stack.ToArray();
// foreach(int num in stuff) {
//     Console.WriteLine(num);
// }

foreach(int num in stack)
{
    Console.WriteLine(num);
}

// for(int i = 0; i < stuff.Length; i++) {
//     Console.WriteLine(stuff[i]);
// }
// Console.WriteLine(stack.Contains(10));
// Console.WriteLine(stack.Contains(30));
// Console.WriteLine(stack.Peek());
// Console.WriteLine(stack);
// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack);


