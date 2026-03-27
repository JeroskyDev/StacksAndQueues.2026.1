namespace SAQ.Backend;

public class StackUsingArray<T> : IStack<T>
{
    private T[] _stack;
    private int _top;

    public StackUsingArray(int capacity)
    {
        _stack = new T[capacity];
        _top = -1;
    }

    public void Push(T item)
    {
        if (_top == _stack.Length - 1)
        {
            throw new InvalidOperationException("Stack is full.");
        }
        _stack[++_top] = item; //increment the top index and then add the item to the stack
    }

    public T Pop()
    {
        if (_top == -1)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _stack[_top--]; //return the top item and then decrement the top index
    }

    public T Peek()
    {
        if (_top == -1)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _stack[_top]; //return the top item without modifying the top index
    }
}
