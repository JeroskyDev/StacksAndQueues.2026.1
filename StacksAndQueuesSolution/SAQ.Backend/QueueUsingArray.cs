namespace SAQ.Backend;

public class QueueUsingArray<T> : IQueue<T>
{
    private T[] _queue; //the actual queue
    private int _front; //the element at the front
    private int _rear;  //the element behind of the front one, it could be named back too
    private int _count; //the count variable

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

