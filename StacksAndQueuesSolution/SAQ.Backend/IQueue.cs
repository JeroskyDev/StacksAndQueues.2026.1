using System;
using System.Collections.Generic;
using System.Text;

namespace SAQ.Backend;

public interface IQueue<T>
{
    T Dequeue();
    void Enqueue(T item);
}
