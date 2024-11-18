using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class InsertionSort<T>
{
    public void Sort(T[] elements)
    {
        int i = 1;
        while(i < elements.Length){
            int j = i;
            
            while(j > 0 && IsGreater(elements[j-1],elements[j])) {
                Swap(elements,j);
                j = j-1;
            }
            i++;
        }
        //You can also use a for loop
        // for(int i = 1; i < elements.Length; i++) {
        //     for(int j = i; j > 0 && IsGreater(elements[j-1],elements[j]); j--)
        //     {

        //     }
        // }

    }


    public void Swap(T[] elements, int j)
    {
        T temp = elements[j];
        elements[j] = elements[j-1];
        elements[j-1] = temp;
    }

    private bool IsGreater(T a, T b)
    {
        return Comparer<T>.Default.Compare(a,b) > 0;
    }


}