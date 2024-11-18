public class MergeSort<T>
{
    public T[] Sort(T[] elements)
    {
        //get the size of the elements
        int n = elements.Length;
        //the base case to stop the recurseve if we already break down all elements to 1
        if(n == 1)
            return elements;
        
        //spilt the elements into two halves
        int midpoint = (int)(n/2);
        //first half
        T[] arrayOne = Copy(elements, 0, midpoint);
        //second half
        T[] arrayTwo = Copy(elements,midpoint, n);

        //recursively breakdown
        arrayOne = Sort(arrayOne);
        arrayTwo = Sort(arrayTwo);


        //merge the halves
        return Merge(arrayOne, arrayTwo);
    }

    public T[] Merge(T[] arrayA, T[] arrayB)
    {
        int arrayALength = arrayA.Length;
        int arrayBLength = arrayB.Length;

        T[] c = new T[arrayALength + arrayBLength];
        int indexA = 0, indexB = 0, indexC = 0;

        //while there are element in both a and b
        while(indexA < arrayA.Length && indexB < arrayB.Length)
        {
            //is arrayA[indexA] > arrayB[indexB]
            if(Comparer<T>.Default.Compare(arrayA[indexA],  arrayB[indexB]) > 0) {
                c[indexC] = arrayB[indexB];
                indexB++;
            } else {
                c[indexC] = arrayA[indexA];
                indexA++;
            }

            indexC++;
        }

        //we still have element for A
        while(indexA < arrayA.Length)
        {
            c[indexC] = arrayA[indexA];
            indexA++;
            indexC++;
        }

        //we still have element for B
        while(indexB < arrayB.Length)
        {
            c[indexC] = arrayB[indexB];
            indexB++;
            indexC++;
        }

        return c;
    }

    private T[] Copy(T[] elements, int start, int end)
    {
        int size = end-start;
        T[] copy = new T[size];

        int index = 0;
        for(int i = start; i < end; i++)
        {
            copy[index] = elements[i];
            index++;
        }

        return copy;
    }
}