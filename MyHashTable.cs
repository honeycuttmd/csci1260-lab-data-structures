// MyHashTable: a tiny dictionary, built to show why lookup takes one step.
// Each bucket holds a short list of pairs. A key's hash code picks its bucket,
// so a lookup searches one short list instead of every pair.
//
// Part F. Build BucketFor and Add along with the Class 3 demo.
// TryGetValue is Exercise 6. Do not use Dictionary anywhere in this class.
public class MyHashTable<TKey, TValue> where TKey : notnull
{
    private List<KeyValuePair<TKey, TValue>>[] buckets;
    private int count;

    // Given. Makes the buckets, each one an empty list of pairs.
    public MyHashTable(int bucketCount)
    {
        buckets = new List<KeyValuePair<TKey, TValue>>[bucketCount];
        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<KeyValuePair<TKey, TValue>>();
        }
        count = 0;
    }

    // Given.
    public int Count => count;

    // TODO: Part F, demo. Write one private helper:
    //   BucketFor(key)  steps 1 and 2: hash the key with GetHashCode, then
    //                   pick a bucket with %. Wrap it in Math.Abs, because
    //                   a hash code can be negative.

    // Adds a pair to the key's bucket. Throw ArgumentException when the key
    // is already in that bucket. Compare keys with Equals(a, b).
    public void Add(TKey key, TValue value)
    {
        // TODO: Part F, demo
        throw new NotImplementedException();
    }

    // Step 3: search only the key's own bucket. When the key is there, set
    // value to its value and return true. When it is not, set value to
    // default and return false.
    public bool TryGetValue(TKey key, out TValue? value)
    {
        // TODO: Part F, Exercise 6
        throw new NotImplementedException();
    }

    // Given. A line like "1 2 1 0 1 0 0": how many pairs sit in each bucket.
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
