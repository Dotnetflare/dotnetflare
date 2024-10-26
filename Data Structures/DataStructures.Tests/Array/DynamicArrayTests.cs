[TestFixture]
public class DynamicArrayTests
{
    [Test]
    public void Add_ShouldIncreaseCount()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(1);
        
        dynamicArray.Count.Should().Be(1);
    }

    [Test]
    public void Add_ShouldResizeWhenCapacityIsExceeded()
    {
        var dynamicArray = new DynamicArray<int>(2);
        dynamicArray.Add(1);
        dynamicArray.Add(2);
        dynamicArray.Add(3);

        dynamicArray.Count.Should().BeGreaterThan(2);
    }

    [Test]
    public void Indexer_Get_ShouldReturnCorrectValue()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(1);

        dynamicArray[0].Should().Be(1);
    }

    [Test]
    public void Indexer_Set_ShouldUpdateValue()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(1);
        dynamicArray[0] = 10;

        dynamicArray[0].Should().Be(10);
    }

    [Test]
    public void RemoveAt_ShouldDecreaseCount()
    {
        var dynamicArray = new DynamicArray<int>();
        dynamicArray.Add(1);
        dynamicArray.Add(2);
        dynamicArray.RemoveAt(0);

        dynamicArray.Count.Should().Be(1);
        dynamicArray[0].Should().Be(2);
    }
}