using System;
using System.Collections.Generic;
using System.Text;
//esto es utilizado para grandes cantidades de información que hagan inestable una cola con arrays.
namespace QueuesUsingArrays;

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
        _queue.RemoveAt(0); //para eliminar fisicamente de la cola, y quitar los elementos fantasmas.
        return item;
    }

    public void Enqueue(T item)
    {
        _queue.Add(item);
    }
}
