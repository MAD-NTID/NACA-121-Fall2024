int[] elements = {3,5,-1,-200,4,0};

//o is pivot the first time
//-1,-200,0,3,5,4


// for(int i = 0; i < elements.Length; i++){
//     Console.WriteLine(elements[i]);
// }

QuickSort<int> quickSort = new QuickSort<int>();

quickSort.Sort(elements, 0, elements.Length-1);


for(int i = 0; i < elements.Length; i++){
    Console.WriteLine(elements[i]);
}