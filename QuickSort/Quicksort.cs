using System.Collections.Concurrent;

public class QuickSort<T>
{
    public void Sort(T[] elements, int lo, int hi)
    {
        //is the starting index a negative value?
        if(lo < 0)
            return ;
        
        if(lo>=hi)
            return ;
        

        //pick a pivot
        int pivotIndex = Partition(elements, lo, hi);

        //recursive on left side of the pivot
        Sort(elements, lo, pivotIndex-1);
        //recursive on the right side of the pivot
        Sort(elements,pivotIndex+1, hi);

        // if(index < 0)
        //     return ;
        
        // if(index >= elements.Length)
        //     return ;
        

        
        // Console.WriteLine(elements[index]);
        // //recursively move on to the next index
        // Sort(elements, index+1);
    }

    public int Partition(T[] elements, int lo, int hi)
    {
        T pivot = elements[hi];
        int i = lo-1;

         for(int j = lo; j <= hi-1; j++)
         {
            if(Comparer<T>.Default.Compare(elements[j], pivot) <0)
            {
                i++;
                Swap(elements, i,j);
            }
         }
         i++;

         Swap(elements, i, hi);

         return i;
    }

    public void Swap(T[] elements, int i, int j)
    {
        T temp = elements[i];
        elements[i] = elements[j];
        elements[j] = temp;
    }
}