/// <summary>
/// Represents a generic first in, first out queue using a circular array.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
public class MyQueue<T>
{
    private T[] items = new T[4];
    private int head = 0; // index of the front item
    private int count = 0;
    public int Count => count;
    public bool IsEmpty => count == 0;

    /// <summary>
    /// Adds an element to the back of the queue, increasing capacity if needed.
    /// </summary>
    /// <param name="item">The element to add.</param>
    public void Enqueue(T item)
    {
        if (count == items.Length)
        {
            Grow();
        }

        int tail = (head + count) % items.Length;
        items[tail] = item;
        count++;
    }

    /// <summary>
    /// Removes the element at the front of the queue.
    /// </summary>
    /// <returns>The element removed from the front of the queue.</returns>
    public T Dequeue()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T item = items[head];
        head = (head + 1) % items.Length;
        count--;

        return item;
    }

    /// <summary>
    /// Shows the element at the front of the queue without removing it.
    /// </summary>
    /// <returns>The element at the front of the queue.</returns>
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return items[head];
    }

    /// <summary>
    /// Doubles the capacity of the circular array while preserving queue order.
    /// </summary>
    private void Grow()
    {
        T[] newItems = new T[items.Length * 2];

        for (int i = 0; i < count; i++)
        {
            newItems[i] = items[(head + i) % items.Length];
        }

        items = newItems;
        head = 0;
    }
}
