using System.Collections;

public class Queue<T> : IQueue<T>, IEnumerable
{
    private Node<T> front;
    private Node<T> back;
    private int count;

    public Queue()
    {
        this.Clear();
    }
    public int Count{
        get{return count;}
    }

    public void Clear()
    {
        this.front = null;
        this.back = null;
        this.count = 0;
    }

    public bool Contains(T element)
    {
       if(this.count == 0)
            return false;
        
        Node<T> current = this.front;

        while(current!=null) 
        {
            bool match = EqualityComparer<T>.Default.Equals(current.Data, element);
            if(match)
                return true;
            
            //move on and search the next one
            current = current.Next;
        }

        //only get here if no match was found
        return false;
    }

    public T Dequeue()
    {
        T data = this.front.Data;

        this.front = this.front.Next;

        count--;

        if(this.front == null) {
            this.back = null;
        }

        return data;
    }

    public void Enqueue(T element)
    {
        //create the new element
        Node<T> node = new Node<T>(element);
        //incremeent the counter
        count++;
        
        //is the front empty?
        if(this.front == null) {
            this.front = this.back = node;
            return ;
        } 

        //the front is not empty so we add the elements to the back
        this.back.Next = node;
        this.back = node;

    }



    public T Peek()
    {
        return this.front.Data;
    }

    public T[] ToArray()
    {
        T[] elements = new T[count];
        int index = 0;

         Node<T> current = this.front;

        while(current!=null) 
        {
            
            elements[index] = current.Data;
            index++;
            //move on and search the next one
            current = current.Next;
        }

        return elements;
    }

    public override string ToString()
    {
        if(this.front == null)
            return "null";
        return this.front.ToString();
    }

    public IEnumerator<T> GetEnumeratorCustom()
    {
         Node<T> current = this.front;

        while(current!=null) 
        {
            
            yield return current.Data;
            //move on and search the next one
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumeratorCustom();
    }


}