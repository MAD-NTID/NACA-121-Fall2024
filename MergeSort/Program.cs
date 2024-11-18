int[] elements = {5,-2,-4,1,3,6,-200};


Console.WriteLine("UnSorted Array");
for(int i = 0; i < elements.Length; i++) {
    Console.WriteLine(elements[i]);
}

MergeSort<int> mergeSort = new MergeSort<int>();
elements = mergeSort.Sort(elements);

Console.WriteLine("Sorted Array");
for(int i = 0; i < elements.Length; i++) {
    Console.WriteLine(elements[i]);
}



