public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    private int count;
    private const int DEFAULT_CAPCITY = 10;
    public const double LOAD_FACTOR = 0.70;
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
        this.EnsureCapacity();

        //get the index location
        int index =this.LinearProbing(key);
        Console.WriteLine($"Adding {key}--> {index}");
        
        //check for duplicate
        if(this.ContainKey(key)){
            throw new ArgumentException("Duplicate key not allowed!");
        }

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
        int index = this.LinearProbing(key, true);
        return index!=-1;

        //return this.buckets[index]!=null;
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
        
        int index = this.LinearProbing(key, true);
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

        int index = this.LinearProbing(key, true);
        this.buckets[index] = null;
        this.count--;
        return true;

    }

    private int LinearProbing(TKey key, bool searchForExistingKey=false)
    {
        //start at a specific index
        int startIndex = this.GetIndex(key);
        int index = startIndex;

        do
        {
            IKeyValuePair<TKey, TValue> kvp = this.buckets[index];

            //we are searching for existing key
            if(searchForExistingKey && kvp is not null){
                if(EqualityComparer<TKey>.Default.Equals(key, kvp.Key))
                    return index;
            } 
            //we are not in search for existing key mode
            else if(!searchForExistingKey && kvp is null) 
            {
                return index;
            }

            index = (index + 1)  % capacity;

        }while(startIndex!=index);


        return -1;
    }

    public void EnsureCapacity()
    {
        double currentLoad = this.count/(double)this.capacity;

        if(currentLoad>=LOAD_FACTOR)
        {
            capacity = capacity * 2;
            IKeyValuePair<TKey, TValue>[] copy= new IKeyValuePair<TKey, TValue>[capacity];

            for(int i = 0; i < this.buckets.Length; i++) {
                copy[i] = this.buckets[i];
            }

            buckets = copy;
        }
    }
}