using Xunit;

namespace SymbolCounter.Tests;

public class CharactersCounterTest
{
    private CharactersCounter _charactersCounter;

    public CharactersCounterTest()
    {
        _charactersCounter = new CharactersCounter();
    }

    [Fact]
    public void UnequalCharactersCounter_ReturnsNumberOf_ConsecutiveUnqualCharacters()
    {
        //Arrange
        string testValues = "acc3+";

        //Act
        _charactersCounter.CharBuilder(testValues);
        var actual = _charactersCounter.UnequalCharactersCounter();

        //Assert 
        Assert.Equal(4, actual);
    }

    [Fact]
    public void EqualLettersCounter_ReturnsNumberOf_ConsecutiveEqualLetters()
    {
        //Arrange
        string testValues = "AA3bb";

        //Act
        _charactersCounter.CharBuilder(testValues);
        var actual = _charactersCounter.EqualLettersCounter();

        //Assert 
        Assert.Equal(4, actual);
    }

    [Fact]
    public void EqualDigitsCounter_ReturnsNumberOf_ConsecutiveEqualDigits()
    {
        //Arrange
        string testValues = "33A44";

        //Act
        _charactersCounter.CharBuilder(testValues);
        var actual = _charactersCounter.EqualDigitsCounter();

        //Assert 
        Assert.Equal(4, actual);
    }
}