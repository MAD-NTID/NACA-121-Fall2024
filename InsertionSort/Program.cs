InsertionSort<int> insertionSort = new InsertionSort<int>();


int[] elements = {1,5,-2,0,3};

insertionSort.Sort(elements);

for(int i = 0; i < elements.Length; i++) {
    Console.Write(elements[i] + " ");
}

Console.WriteLine();
