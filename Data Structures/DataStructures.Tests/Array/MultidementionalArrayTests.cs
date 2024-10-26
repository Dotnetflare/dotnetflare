[TestFixture]
public class MultidimensionalArrayTests
{
    private MultidimensionalArray<int> _array;

    [SetUp]
    public void SetUp()
    {
        _array = new MultidimensionalArray<int>(3, 3);
    }

    [Test]
    public void Add_ShouldStoreValueAtSpecifiedPosition()
    {
        _array.Add(1, 1, 42);
        _array.Get(1, 1).Should().Be(42);
    }

    [Test]
    public void Get_ShouldReturnCorrectValue()
    {
        _array.Add(2, 2, 99);
        var value = _array.Get(2, 2);
        value.Should().Be(99);
    }

    [Test]
    public void Remove_SpecificPosition_ShouldShiftValuesLeft()
    {
        _array.Add(0, 0, 10);
        _array.Add(0, 1, 20);
        _array.Add(0, 2, 30);
        _array.Remove(0, 1);

        _array.Get(0, 1).Should().Be(30);
        _array.Get(0, 2).Should().Be(default(int));
    }

    [Test]
    public void Remove_EntireRow_ShouldShiftRowsUp()
    {
        _array.Add(0, 0, 10);
        _array.Add(1, 0, 20);
        _array.Add(2, 0, 30);

        _array.Remove(1);

        _array.Get(1, 0).Should().Be(30);
        _array.Get(2, 0).Should().Be(default(int));
    }

    [Test]
    public void Add_ShouldThrowException_WhenIndexOutOfBounds()
    {
        Assert.Throws<IndexOutOfRangeException>(() => _array.Add(5, 5, 99));
    }

    [Test]
    public void Get_ShouldThrowException_WhenIndexOutOfBounds()
    {
        Assert.Throws<IndexOutOfRangeException>(() => _array.Get(5, 5));
    }

    [Test]
    public void Remove_ShouldThrowException_WhenRowIndexOutOfBounds()
    {
        Assert.Throws<IndexOutOfRangeException>(() => _array.Remove(5));
    }

    [Test]
    public void Remove_ShouldThrowException_WhenColumnIndexOutOfBounds()
    {
        Assert.Throws<IndexOutOfRangeException>(() => _array.Remove(0, 5));
    }
}