/// <summary>
/// Represents a generic hash table that stores key-value pairs in separate buckets.
/// </summary>
/// <typeparam name="TKey">The type of keys stored in the hash table.</typeparam>
/// <typeparam name="TValue">The type of values associated with the keys.</typeparam>
public class MyHashTable<TKey, TValue> where TKey : notnull
{
    private List<KeyValuePair<TKey, TValue>>[] buckets;
    private int count;

    /// <summary>
    /// Initializes a hash table with the specified number of buckets.
    /// </summary>
    /// <param name="bucketCount">The number of buckets to create.</param>
    public MyHashTable(int bucketCount)
    {
        buckets = new List<KeyValuePair<TKey, TValue>>[bucketCount];
        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<KeyValuePair<TKey, TValue>>();
        }
        count = 0;
    }

    public int Count => count;

    /// <summary>
    /// Determines which bucket a key belongs to using its hash code.
    /// </summary>
    /// <param name="key">The key used to calculate the bucket index.</param>
    /// <returns>The index of the bucket associated with the key.</returns>
    private int BucketFor(TKey key)
    {
        int hash = key.GetHashCode();
        return Math.Abs(hash % buckets.Length);
    }

    /// <summary>
    /// Adds a key-value pair to the appropriate bucket if the key does not already exist.
    /// </summary>
    /// <param name="key">The key to add.</param>
    /// <param name="value">The value associated with the key.</param>
    public void Add(TKey key, TValue value)
    {
        int index = BucketFor(key);

        foreach (KeyValuePair<TKey, TValue> pair in buckets[index])
        {
            if (Equals(pair.Key, key))
            {
                throw new ArgumentException("Key already exists.");
            }
        }

        buckets[index].Add(new KeyValuePair<TKey, TValue>(key, value));
        count++;
    }

    /// <summary>
    /// Searches the appropriate bucket for a key and retrieves its associated value.
    /// </summary>
    /// <param name="key">The key to search for.</param>
    /// <param name="value">The value associated with the key, or the default value if not found.</param>
    /// <returns>True if the key is found; otherwise, false.</returns>
    public bool TryGetValue(TKey key, out TValue? value)
    {
        int index = BucketFor(key);

        foreach (KeyValuePair<TKey, TValue> pair in buckets[index])
        {
            if (Equals(pair.Key, key))
            {
                value = pair.Value;
                return true;
            }
        }

        value = default;
        return false;
    }

    /// <summary>
    /// Returns the number of key-value pairs stored in each bucket.
    /// </summary>
    /// <returns>A space separated string containing the bucket sizes.</returns>
    public string BucketSizes()
    {
        string result = "";
        for (int i = 0; i < buckets.Length; i++)
        {
            if (i > 0)
            {
                result += " ";
            }
            result += buckets[i].Count;
        }
        return result;
    }
}
