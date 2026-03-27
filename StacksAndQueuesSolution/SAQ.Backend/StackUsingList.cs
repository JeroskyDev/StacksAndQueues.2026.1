using System;
using System.Collections.Generic;
using System.Text;

namespace SAQ.Backend;

public class StackUsingList<T> : IStack<T> // A list is infinite (but have maximum capacity of memory) we asume that our memory is infinite. By the way, Lists doesn´t have a size, they just get values in them, and we don´t have a top value.
{
    //fields
    private List<T> _stack = [];

    //methods
    public T Peek()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T item = _stack[_stack.Count - 1];
        return item;
    }

    public T Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T item = _stack[_stack.Count - 1];
        _stack.RemoveAt(_stack.Count - 1);
        return item;
    }
    public void Push(T item)
    {
        _stack.Add(item);
    }
}
