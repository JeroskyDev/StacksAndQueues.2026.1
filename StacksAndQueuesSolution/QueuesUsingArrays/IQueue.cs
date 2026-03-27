using System;
using System.Collections.Generic;
using System.Text;

namespace QueuesUsingArrays;

public interface IQueue<T>
{
    T Dequeue();
    void Enqueue(T item);
}
