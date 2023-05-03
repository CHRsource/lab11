#pragma warning disable
public class DoublyNodeG<T>
{
    public DoublyNodeG(T data)
    {
        Data = data;
    }
    public T Data { get; set; }
    public DoublyNodeG<T> Previous { get; set; }
    public DoublyNodeG<T> Next { get; set; }
}
