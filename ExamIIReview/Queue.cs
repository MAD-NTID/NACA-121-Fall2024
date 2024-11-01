public class Queue<T>
{
    private int size;
    private int front;
    private T[] elements;

    public Queue(int capacity)
    {
        this.elements = new T[capacity];
        this.front = 0;
        this.size = 0;
    }

    
    public int Size 
    { 
        get
        {
            return this.size;
        }

        set
        {
            this.size = value;
        }
    }

    public T Peek()
    {
        return this.elements[front];
    }

    public T Dequeue()
    {
        T element = this.Peek();
        this.elements[front] = default;
        front++;
        this.size--;
        return element;
    }
    
    public void Enqueue(T element)
    {
        this.elements[size] = element;
        this.size++;
        
    }

    public override string ToString()
    {
        if(size == 0)
            return "null";
        
        string order = "";
        for(int i = front; i < size; i++){
            order+=this.elements[i].ToString() + "-->";
        }

        return order + "null";
    }
}