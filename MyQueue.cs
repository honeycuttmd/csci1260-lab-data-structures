// MyQueue: first in, first out, built on a circular array.
//
// Part D. Build this class along with the Class 2 demo.
// Dequeue moves the head index. It never shifts the items.
public class MyQueue<T>
{
    private T[] items = new T[4];
    private int head = 0;    // index of the front item
    private int count = 0;

    // Given.
    public int Count => count;
    public bool IsEmpty => count == 0;

    // Join the back of the line. Grow first if every slot is taken.
    // The back of the line is at (head + count) % items.Length.
    public void Enqueue(T item)
    {
        // TODO: Part D, demo
        throw new NotImplementedException();
    }

    // Leave from the front of the line. Move head forward one slot,
    // wrapping with %, and hand back the item that was in front.
    public T Dequeue()
    {
        // TODO: Part D, demo
        throw new NotImplementedException();
    }

    // Given. Look at the front item without removing it.
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return items[head];
    }

    // TODO: Part D. Write one private helper:
    //   Grow()  copy the items FRONT TO BACK into an array twice the size,
    //           so the line starts at slot 0 again, then set head to 0
}
