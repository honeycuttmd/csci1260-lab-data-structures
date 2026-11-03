/// <summary>
/// Represents a generic last in, first out stack using a MyList.
/// </summary>
/// <typeparam name="T">The type of elements stored in the stack.</typeparam>
public class MyStack<T>
{
    private MyList<T> items = new MyList<T>();

    public int Count => items.Count;

    public bool IsEmpty => Count == 0;

    /// <summary>
    /// Adds an element to the top of the stack.
    /// </summary>
    /// <param name="item">The element to add.</param>
    public void Push(T item)
    {
        items.Add(item);
    }

    /// <summary>
    /// Removes the element at the top of the stack.
    /// </summary>
    /// <returns>The element removed from the top of the stack.</returns>
    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = items[Count - 1];
        items.RemoveAt(Count - 1);
        return item;
    }

    /// <summary>
    /// Shows the element at the top of the stack without removing it.
    /// </summary>
    /// <returns>The element at the top of the stack.</returns>
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return items[Count - 1];
    }
}
