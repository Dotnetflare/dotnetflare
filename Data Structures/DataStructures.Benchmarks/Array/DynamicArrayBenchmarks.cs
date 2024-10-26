public class DynamicArrayBenchmark
{
    private DynamicArray<int> _dynamicArray;

    [GlobalSetup]
    public void Setup()
    {
        _dynamicArray = new DynamicArray<int>();
    }

    [Benchmark]
    public void AddElements()
    {
        for (int i = 0; i < 1000; i++)
        {
            _dynamicArray.Add(i);
        }
    }

    [Benchmark]
    public void RemoveElements()
    {
        for (int i = 0; i < 1000; i++)
        {
            _dynamicArray.Add(i);
        }
        for (int i = 999; i >= 0; i--)
        {
            _dynamicArray.RemoveAt(i);
        }
    }
}