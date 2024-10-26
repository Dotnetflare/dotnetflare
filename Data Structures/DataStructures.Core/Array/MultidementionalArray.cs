public class MultidimensionalArray<T>
{
    private T[,] _array;

    public MultidimensionalArray(int rows, int columns)
    {
        _array = new T[rows, columns];
    }

    public T this[int row, int column]
    {
        get => _array[row, column];
        set => _array[row, column] = value;
    }

    public int Rows => _array.GetLength(0);
    public int Columns => _array.GetLength(1);

    public void Add(int row, int column, T value)
    {
        if (row >= Rows || column >= Columns)
            throw new IndexOutOfRangeException("Invalid index");
        _array[row, column] = value;
    }

    public T Get(int row, int column)
    {
        if (row >= Rows || column >= Columns)
            throw new IndexOutOfRangeException("Invalid index");
        return _array[row, column];
    }

    public void Remove(int row)
    {
        if (row < 0 || row >= Rows)
            throw new IndexOutOfRangeException("Invalid row index");

        for (int r = row; r < Rows - 1; r++)
        {
            for (int c = 0; c < Columns; c++)
            {
                _array[r, c] = _array[r + 1, c];
            }
        }

        // Set the last row to default values
        for (int c = 0; c < Columns; c++)
        {
            _array[Rows - 1, c] = default(T);
        }
    }

    public void Remove(int row, int column)
    {
        if (row >= Rows || column >= Columns)
            throw new IndexOutOfRangeException("Invalid index");

        for (int r = row; r < Rows; r++)
        {
            for (int c = column; c < Columns - 1; c++)
            {
                _array[r, c] = _array[r, c + 1];
            }
            if (r < Rows - 1)
            {
                _array[r, Columns - 1] = _array[r + 1, 0];
            }
        }
        _array[Rows - 1, Columns - 1] = default(T);
    }
}