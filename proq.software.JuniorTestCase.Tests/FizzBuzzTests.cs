using proq.software.JuniorTestCase.Tests.TestData;
using static proq.software.JuniorTestCase.Tests.TestData.FizzBuzzTestData;

namespace proq.software.JuniorTestCase.Tests;

public class FizzBuzzTests
{
    [Theory(DisplayName = "Task1: Кратные трём - fizz, кратные пяти - buzz")]
    [MemberData(memberName: nameof(FirstTaskData), MemberType = typeof(FizzBuzzTestData))]
    public void FizzBuzz_Task1(int number, string expected)
    {
        // Arrange
        List<int> numbers = new() { number };

        // Act
        var result = FizzBuzz.FizzBuzzOne(numbers);

        // Assert
        foreach (var str in result)
        {
            Assert.Equal(expected, str);
        }
    }

    [Theory(DisplayName = "Task2: Корректно заменяет на fizz, buzz, muzz, quzz")]
    [MemberData(memberName: nameof(SecondTaskData), MemberType = typeof(FizzBuzzTestData))]
    public void Test_FizzBuzzSecond(int number, string expected)
    {
        // Arrange
        List<int> numbers = new() { number };

        // Act
        var result = FizzBuzz.FizzBuzzSecond(numbers);

        // Assert
        foreach (var str in result)
        {
            Assert.Equal(expected, str);
        }
    }
    
    [Theory(DisplayName = "Task3: Корректно заменяет на cat, dog, good-boy, muzz, quzz")]
    [MemberData(memberName: nameof(ThirdTaskData), MemberType = typeof(FizzBuzzTestData))]
    public void Test_FizzBuzzThird(int number, string expected)
    {
        // Arrange
        List<int> numbers = new() { number };

        // Act
        var result = FizzBuzz.FizzBuzzThird(numbers);

        // Assert
        foreach (var str in result)
        {
            Assert.Equal(expected, str);
        }
    }
}