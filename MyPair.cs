#pragma warning disable
public class MyPair<T1, T2>
{
    protected T1 first;
    protected T2 second;
    public MyPair(T1 first, T2 second)
    {
        this.first = first;
        this.second = second;
    }
    public object this[int index]
    {
        get
        {
            if (index == 0) return first;
            else if (index == 1) return second;
            else throw new IndexOutOfRangeException("Индекс должен быть 0 или 1");
        }
        set
        {
            if (index == 0) first = (T1)value;
            else if (index == 1) second = (T2)value;
            else throw new IndexOutOfRangeException("Индекс должен быть 0 или 1");
        }
    }

}
