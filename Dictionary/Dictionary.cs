public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    private int count;
    private const int DEFAULT_CAPCITY = 10;
    private int capacity;
    private IKeyValuePair<TKey, TValue>[] buckets;

    public Dictionary(int capacity)
    {
        this.count = 0;
        this.buckets = new IKeyValuePair<TKey, TValue>[capacity];
        this.capacity = capacity;
    }

    public Dictionary():this(DEFAULT_CAPCITY)
    {

    }

    public int Count{
        get{return count;}
    }

    public void Add(TKey key, TValue value)
    {
        //check for duplicate
        if(this.ContainKey(key)){
            throw new ArgumentException("Duplicate key not allowed!");
        }

        //get the index location
        int index = this.GetIndex(key);



        IKeyValuePair<TKey, TValue> kvp = new KeyValuePair<TKey, TValue>(key, value);
        this.buckets[index] = kvp;
        this.count++;


    }

    public void Clear()
    {
        this.count = 0;
        this.buckets = new IKeyValuePair<TKey, TValue>[capacity];
    }

    public bool ContainKey(TKey key)
    {
        int index = this.GetIndex(key);

        return this.buckets[index]!=null;
    }

    public bool ContainValue(TValue value)
    {
       foreach(IKeyValuePair<TKey, TValue> kvp in this.buckets)
       {
            if(kvp is not null && EqualityComparer<TValue>.Default.Equals(kvp.Value, value))
            {
                return true;
            }
       }

       return false;
    }

    public IKeyValuePair<TKey, TValue> Get(TKey key)
    {
        if(!this.ContainKey(key))
            throw new ArgumentException($"Key {key} doenst exist!");
        
        int index = this.GetIndex(key);
        return this.buckets[index];
    }

    public int GetIndex(TKey key)
    {
        int hash = Math.Abs(key.GetHashCode());

        //use mod to ensure it stay in range
        return hash % this.capacity;

    }

    public bool Remove(TKey key)
    {
        if(!this.ContainKey(key))
            return false;

        int index = this.GetIndex(key);
        this.buckets[index] = null;
        this.count--;
        return true;

    }
}