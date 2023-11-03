namespace proq.software.JuniorTestCase.Tests.TestData;

public static class FizzBuzzTestData
{
    public static readonly IEnumerable<object[]> FirstTaskData =
        new[]
        {
            new object[] { 1, "1" },
            new object[] { 3, "fizz" },
            new object[] { 6, "fizz" },
            new object[] { 9, "fizz" },
            new object[] { 5, "buzz" },
            new object[] { 10, "buzz" },
            new object[] { 15, "fizz-buzz" },
        };

    public static readonly IEnumerable<object[]> SecondTaskData =
        new[]
        {
            new object[] { 1, "1" },
            new object[] { 2, "2" },
            new object[] { 3, "fizz" },
            new object[] { 4, "muzz" },
            new object[] { 5, "buzz" },
            new object[] { 6, "fizz" },
            new object[] { 7, "guzz" },
            new object[] { 8, "muzz" },
            new object[] { 9, "fizz" },
            new object[] { 10, "buzz" },
            new object[] { 11, "11" },
            new object[] { 12, "fizz-muzz" },
            new object[] { 13, "13" },
            new object[] { 14, "guzz" },
            new object[] { 15, "fizz-buzz" },
            new object[] { 60, "fizz-buzz-muzz" },
            new object[] { 105, "fizz-buzz-guzz" },
            new object[] { 420, "fizz-buzz-muzz-guzz" }
        };

    public static readonly IEnumerable<object[]> ThirdTaskData =
        new[]
        {
            new object[] { 1, "1" },
            new object[] { 2, "2" },
            new object[] { 3, "dog" },
            new object[] { 4, "muzz" },
            new object[] { 5, "cat" },
            new object[] { 6, "dog" },
            new object[] { 7, "guzz" },
            new object[] { 8, "muzz" },
            new object[] { 9, "dog" },
            new object[] { 10, "cat" },
            new object[] { 11, "11" },
            new object[] { 12, "dog-muzz" },// В примере ошибка: метод никогда не должен выводить fizz :)
            new object[] { 13, "13" },
            new object[] { 14, "guzz" },
            new object[] { 15, "good-boy" },
            new object[] { 60, "good-boy-muzz" },
            new object[] { 105, "good-boy-guzz" },
            new object[] { 420, "good-boy-muzz-guzz" }
        };
}