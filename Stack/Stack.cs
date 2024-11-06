using System.Collections;

public class Stack<T> : IStack<T>, IEnumerable
{
    private int count;
    private Node<T> top;

    public Stack()
    {
        this.count = 0;
    }
    public int Count{
        get{
            return count;
        }
    }

    public void Clear()
    {
        this.top = null;
        this.count = 0;
    }

    public bool Contains(T element)
    {
        if(this.top== null)
            return false;

        Node<T> current = top;

        while(current is not null) 
        {
            bool match = EqualityComparer<T>.Default.Equals(element, current.Data);
            if(match)
                return true;
            
            current = current.Next;
        }

        return false;
    }

    public T Peek()
    {
        return this.top.Data;
    }

    public T Pop()
    {
        T data = this.top.Data;
        top = top.Next;
        count--;
        return data;
    }

    public void Push(T element)
    {
        Node<T> currentTop = top;

        Node<T> node = new Node<T>(element, currentTop);
        top = node;
        count++;
        
    }

    public T[] ToArray()
    {
        T[] elements = new T[count];
        int index = 0;
        Node<T> current = top;
        while(current is not null) 
        {
            elements[index] = current.Data;
            current = current.Next;
            index++;
        }

        return elements;

    }

    public override string ToString()
    {
        if(top==null)
            return "null";

        return this.top.ToString();
    }

    public IEnumerator<T> GetEnumeratorCustom()
    {
        Node<T> current = top;
        while(current is not null) 
        {
            yield return current.Data;
            current = current.Next;

        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumeratorCustom();
    }
}