/// <summary>
/// Represents a generic list that manages its elements in a resizable array.
/// </summary>
/// <typeparam name="T">The type of elements stored in the list.</typeparam>
public class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[4];
        count = 0;
    }

    public int Count => count;

    public int Capacity => items.Length;

    /// <summary>
    /// Adds an element to the end of the list, increasing capacity if needed.
    /// </summary>
    /// <param name="item">The element to add.</param>
    public void Add(T item)
    {
        if (count == items.Length)
        {
            Grow();
        }

        items[count] = item;
        count++;
    }

    public T this[int index]
    {
        get
        {
            CheckIndex(index);
            return items[index];
        }
        set
        {
            CheckIndex(index);
            items[index] = value;
        }
    }

    /// <summary>
    /// Inserts an element at the specified index by shifting existing elements to the right.
    /// </summary>
    /// <param name="index">The index where the element will be inserted.</param>
    /// <param name="item">The element to insert.</param>
    public void Insert(int index, T item)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 0 and Count (inclusive).");
        }

        if (count == items.Length)
        {
            Grow();
        }

        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }

        items[index] = item;
        count++;
    }

    /// <summary>
    /// Removes the element at the specified index by shifting remaining elements to the left.
    /// </summary>
    /// <param name="index">The index of the element to remove.</param>
    public void RemoveAt(int index)
    {
        CheckIndex(index);

        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        count--;
    }

    /// <summary>
    /// Finds the index of the first matching element in the list.
    /// </summary>
    /// <param name="item">The element to search for.</param>
    /// <returns>The index of the first match, or -1 if the element is not found.</returns>
    public int IndexOf(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (Equals(items[i], item))
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// Returns the list of elements as a formatted comma separated string.
    /// </summary>
    /// <returns>A string containing the list elements enclosed in brackets.</returns>
    public override string ToString()
    {
        string result = "[";
        for (int i = 0; i < count; i++)
        {
            if (i > 0)
            {
                result += ", ";
            }
            result += items[i];
        }
        return result + "]";
    }

    /// <summary>
    /// Doubles the capacity of the internal array while preserving existing elements.
    /// </summary>
    private void Grow()
    {
        T[] newItems = new T[items.Length * 2];

        for (int i = 0; i < count; i++)
        {
            newItems[i] = items[i];
        }

        items = newItems;
    }

    /// <summary>
    /// Validates that an index is within the occupied portion of the list.
    /// </summary>
    /// <param name="index">The index to validate.</param>
    private void CheckIndex(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be between 0 and Count - 1.");
        }
    }
}