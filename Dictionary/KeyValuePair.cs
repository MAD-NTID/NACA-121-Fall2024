public class KeyValuePair<TKey, TValue> : IKeyValuePair<TKey, TValue>
{
    private TKey key;
    private TValue value;

    public TKey Key
    {
        get{return key;}
    }

    public TValue Value
    {
        get{return value;}
    }

    public KeyValuePair(TKey key, TValue value)
    {
        this.key = key;
        this.value = value;
    }

    public override string ToString()
    {
        return $"{key}:{value}";
    }


}