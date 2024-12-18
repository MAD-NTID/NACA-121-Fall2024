public interface IDictionary<TKey, TValue>
{
    public const double LOAD_FACTOR = 0.70;
    public int Count{get;}

    public void Clear();

    public bool ContainKey(TKey key);
    public bool ContainValue(TValue value);
    public void EnsureCapacity();
    public void Add(TKey key, TValue value);

    public bool Remove(TKey key);

    public int GetIndex(TKey key);

    public IKeyValuePair<TKey, TValue> Get(TKey key);
}