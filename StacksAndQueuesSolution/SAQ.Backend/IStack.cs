namespace SAQ.Backend;

public interface IStack<T>
{
    T Peek();
    T Pop();
    void Push(T item);
}