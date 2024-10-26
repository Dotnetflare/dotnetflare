public class DynamicArray<T>
{
    private T[] _array;
    private int _count;
    private int _capacity;

    public DynamicArray(int capacity = 4)
    {
        _capacity = capacity;
        _array = new T[_capacity];
        _count = 0;
    }

    public int Count => _count;

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException("Index out of range");
            return _array[index];
        }
        set
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException("Index out of range");
            _array[index] = value;
        }
    }

    public void Add(T item)
    {
        if (_count == _capacity)
        {
            Extend();
        }
        _array[_count] = item;
        _count++;
    }

    private void Extend(int growthPercentage = 25)
    {
        int increase = (int)Math.Ceiling(_capacity * growthPercentage / 100.0);
        _capacity += increase;

        T[] newArray = new T[_capacity];
        for (int i = 0; i < _count; i++)
        {
            newArray[i] = _array[i];
        }
        _array = newArray;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException("Index out of range");

        for (int i = index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _count--;
        _array[_count] = default;
    }
}