namespace QueuesUsingArrays;

public class QueueUsingArray<T>
{
    private T[] _queue; //cola
    private int _front; //elemento al frente
    private int _rear;  //elemento detrás puede llamarse back tambien
    private int _count; //contador

    public QueueUsingArray(int capacity)
    {
        _queue = new T[capacity];
        _front = 0;
        _rear = -1;
       _count = 0;
    }

    public void Enqueue(T item)
    {
        if (_count == _queue.Length)
        {
            throw new InvalidOperationException("Queue is full.");
        }
        _rear = (_rear + 1) % _queue.Length;
        _queue[_rear] = item;
        _count++;
    }

    public T Dequeue()
    {
        if ( _count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        var item = _queue[_front];
        _front = (_front + 1) % _queue.Length;
        _count--;
        return item;
    }
}

