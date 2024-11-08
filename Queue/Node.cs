public class Node<T>
{
    private T data;
    private Node<T> next;

    public T Data { 
        get{return data;}
        set{data = value;} 
        }
    
    public Node<T> Next { get{return next;} set{next = value;} }


    public Node(T data, Node<T> next)
    {
        this.data = data;
        this.next = next;
    }

    public Node(T data)
    {
        this.data = data;
        this.next = null;
    }

    public override string ToString()
    {
        if(this.next==null)
            return this.data.ToString() + "-->null";
        
        return this.data.ToString() + "-->" + this.next.ToString();
    }


}