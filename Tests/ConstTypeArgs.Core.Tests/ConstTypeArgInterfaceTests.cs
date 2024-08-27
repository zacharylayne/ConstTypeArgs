using FluentAssertions;

namespace ConstTypeArgs.Core.Tests;

public partial class ConstTypeArgInterfaceTests
{
    [Fact]
    public void IConstTypeArgT_ShouldImplement_IConstTypeArg()
    {
        // Arrange
        var type = typeof(IConstTypeArg<int>);

        // Act & Assert
        type.Should().Implement<IConstTypeArg>();
    }

    [Fact]
    public void IntConstTypeArg_ShouldImplement_IConstTypeArgT()
    {
        // Arrange
        var type = typeof(IntConstTypeArg);

        // Act
        var implementsInterface = typeof(IConstTypeArg<int>).IsAssignableFrom(type);

        // Assert
        implementsInterface.Should().BeTrue("IntConstTypeArg should implement IConstTypeArg<int>");
    }

    [Fact]
    public void FakeConstTypeArg_ShouldImplement_IConstTypeArgT()
    {
        // Arrange
        var type = typeof(IntConstTypeArg);

        // Act
        var implementsInterface = typeof(IConstTypeArg<int>).IsAssignableFrom(type);

        // Assert
        implementsInterface.Should().BeTrue("FakeConstTypeArg should implement IConstTypeArg<int>");
    }

    [Fact]
    public void IntConstTypeArg_Value_ShouldReturnExpectedValue()
    {
        // Arrange
        const int expectedValue = 42;

        // Act
        var value = IntConstTypeArg.Value;

        // Assert
        value.Should().Be(expectedValue, "IntConstTypeArg.Value should return 42");
    }
}
