public class Stack<T>
{
    private int size;
    private int top;
    private T[] elements;

    public Stack(int capacity)
    {
        this.elements = new T[capacity];
        this.top = -1;
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
        return this.elements[top];
    }

    public T Pop()
    {
        T element = this.Peek();
        this.elements[top] = default;
        top--;
        this.size--;
        return element;
    }
    
    public void Push(T element)
    {
        this.elements[size] = element;
        this.size++;
        this.top++;

    }

    public override string ToString()
    {
        if(size == 0)
            return "null";
        
        string order = "";
        for(int i = top; i>=0; i--){
            order+=this.elements[i].ToString() + "-->";
        }

        return order + "null";
    }
}