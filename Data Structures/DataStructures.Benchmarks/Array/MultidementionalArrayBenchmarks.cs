[MemoryDiagnoser]
public class MultidimensionalArrayBenchmark
{
    private MultidimensionalArray<int> _array;

    [GlobalSetup]
    public void Setup()
    {
        _array = new MultidimensionalArray<int>(100, 100);
    }

    [Benchmark]
    public void AddBenchmark()
    {
        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 100; j++)
                _array.Add(i, j, i * j);
    }

    [Benchmark]
    public void GetBenchmark()
    {
        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 100; j++)
                _array.Get(i, j);
    }

    [Benchmark]
    public void RemoveRowBenchmark()
    {
        for (int i = 0; i < 100; i++)
            _array.Remove(i);
    }

    [Benchmark]
    public void RemoveElementBenchmark()
    {
        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 100; j++)
                _array.Remove(i, j);
    }
}