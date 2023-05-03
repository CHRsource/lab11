#pragma warning disable
using System.Collections.Generic;
using System.Collections;
public class DoublyLinkedListG<T> : IEnumerable<T>  // двусвязный список
{
    DoublyNodeG<T> head; // головной/первый элемент
    DoublyNodeG<T> tail; // последний/хвостовой элемент
    int count;  // количество элементов в списке

    // добавление элемента
    public void Add(T data)
    {
        DoublyNodeG<T> node = new DoublyNodeG<T>(data);

        if (head == null)
            head = node;
        else
        {
            tail.Next = node;
            node.Previous = tail;
        }
        tail = node;
        count++;
    }
    public void AddFirst(T data)
    {
        DoublyNodeG<T> node = new DoublyNodeG<T>(data);
        DoublyNodeG<T> temp = head;
        node.Next = temp;
        head = node;
        if (count == 0)
            tail = head;
        else
            temp.Previous = node;
        count++;
    }
    // удаление
    public bool Remove(T data)
    {
        DoublyNodeG<T> current = head;

        // поиск удаляемого узла
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                break;
            }
            current = current.Next;
        }
        if (current != null)
        {
            // если узел не последний
            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                // если последний, переустанавливаем tail
                tail = current.Previous;
            }

            // если узел не первый
            if (current.Previous != null)
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                // если первый, переустанавливаем head
                head = current.Next;
            }
            count--;
            return true;
        }
        return false;
    }

    public int Count { get { return count; } }
    public bool IsEmpty { get { return count == 0; } }

    public void Clear()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public bool Contains(T data)
    {
        DoublyNodeG<T> current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
                return true;
            current = current.Next;
        }
        return false;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        DoublyNodeG<T> current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    public IEnumerable<T> BackEnumerator()
    {
        DoublyNodeG<T> current = tail;
        while (current != null)
        {
            yield return current.Data;
            current = current.Previous;
        }
    }
    public override string ToString()
    {
        DoublyNodeG<T> current = head;
        string s = "";
        if (current == null) return "empty";
        s += current.Data;
        current = current.Next;
        while (current != null)
        {
            s = s + " " + current.Data;
            current = current.Next;
        }
        return s;
    }
}
