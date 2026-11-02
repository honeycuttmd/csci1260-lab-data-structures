// MyStack: last in, first out.
//
// Part C. Build this class along with the Class 2 demo.
// A stack HAS A MyList. It does not inherit from one.
public class MyStack<T>
{
    // TODO: Part C. Declare one private field: a MyList<T> that holds
    // the items. The top of the stack is the END of the list.

    // TODO: Part C. How many items are on the stack.
    public int Count => throw new NotImplementedException();

    // TODO: Part C. True when the stack holds nothing.
    public bool IsEmpty => throw new NotImplementedException();

    // Put an item on top.
    public void Push(T item)
    {
        // TODO: Part C, demo
        throw new NotImplementedException();
    }

    // Take the top item off and hand it back.
    public T Pop()
    {
        // TODO: Part C, demo
        throw new NotImplementedException();
    }

    // Look at the top item without removing it. On an empty stack, throw
    // InvalidOperationException("Stack is empty.").
    public T Peek()
    {
        // TODO: Part C, demo
        throw new NotImplementedException();
    }
}
