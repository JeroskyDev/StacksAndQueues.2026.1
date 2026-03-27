using System;
using System.Collections.Generic;
using System.Text;
//this is used for big quantities of information that make unstable a queue with arrays.
namespace SAQ.Backend;

public class QueueUsingList<T> : IQueue<T> 
{
    private List<T> _queue = [];
    public T Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        var item = _queue[0];
        _queue.RemoveAt(0); //to delete physically from queue, and to delete the ghost elements.
        return item;
    }

    public void Enqueue(T item)
    {
        _queue.Add(item);
    }
}
