// MyList: an array that manages itself. It tracks the count, grows by
// doubling when it is full, and refuses any index that is not in use.
//
// Part B. Build this class along with the Class 1 demo.
// Insert is Exercise 2.
public class MyList<T>
{
    private T[] items;
    private int count;

    // Given. Every list starts with room for four items.
    public MyList()
    {
        items = new T[4];
        count = 0;
    }

    // TODO: Part B. How many slots are in use.
    public int Count => throw new NotImplementedException();

    // TODO: Part B. How many slots exist (the array's Length).
    public int Capacity => throw new NotImplementedException();

    // Add to the end. Grow first if every slot is taken.
    public void Add(T item)
    {
        // TODO: Part B, demo
        throw new NotImplementedException();
    }

    // The indexer is the code behind list[2]. Both get and set must
    // refuse any index that is not in use.
    public T this[int index]
    {
        get
        {
            // TODO: Part B, demo
            throw new NotImplementedException();
        }
        set
        {
            // TODO: Part B, demo
            throw new NotImplementedException();
        }
    }

    // Insert anywhere from 0 to Count. Inserting at Count is legal and
    // means the same thing as Add. Throw ArgumentOutOfRangeException
    // for anything else.
    public void Insert(int index, T item)
    {
        // TODO: Part B, Exercise 2
        throw new NotImplementedException();
    }

    // Remove the item at index and close the gap.
    public void RemoveAt(int index)
    {
        // TODO: Part B, demo
        throw new NotImplementedException();
    }

    // Linear search. Return the index, or -1 when the item is not there.
    // Compare with Equals(a, b), which works for every type T.
    public int IndexOf(T item)
    {
        // TODO: Part B, demo
        throw new NotImplementedException();
    }

    // Given. Builds a line like "[A, B, C]" from the slots in use.
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

    // TODO: Part B. Write two private helpers:
    //   Grow()            make a new array twice the size, copy every item
    //   CheckIndex(index) throw ArgumentOutOfRangeException unless
    //                     0 <= index < count
}
