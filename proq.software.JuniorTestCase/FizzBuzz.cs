namespace proq.software.JuniorTestCase;

/// <summary>
///     Тестовое задание для Флексибейс
/// </summary>
public sealed class FizzBuzz
{
    /// <summary>
    ///     Если число делится на 3 без остатка - заменить его на "fizz",
    ///     если делится на 5 без остатка - заменить его на "buzz",
    ///     если делится на 3 и на 5 без остатка - заменить на "fizz-buzz"
    /// </summary>
    /// <param name="numbers">Список чисел</param>
    /// <returns>Обработанный список чисел с заменами</returns>
    public static IEnumerable<string> FizzBuzzOne(IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            var result = FizzBuzzReplacerFirst(number);

            if (string.IsNullOrEmpty(result))
            {
                yield return number.ToString();
                continue;
            }

            yield return result;
        }
    }

    private static string FizzBuzzReplacerFirst(int number)
    {
        var result = "";
        if (number % 3 == 0) result += "fizz";

        if (number % 5 == 0)
        {
            if (!string.IsNullOrEmpty(result)) result += "-";
            result += "buzz";
        }

        return result;
    }

    /// <summary>
    ///     Функционал <see cref="FizzBuzzOne" /> +
    ///     Если делится на 4 без остатка - заменить на "muzz",
    ///     если делится на 7 без остатка - заменить на "guzz",
    ///     если делится на 4 и 7 без остатка - заменить на "muzz-guzz".
    /// </summary>
    /// <param name="numbers">Список чисел</param>
    /// <returns>Обработанный список чисел с заменами</returns>
    public static IEnumerable<string> FizzBuzzSecond(IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            var result = FizzBuzzReplacerFirst(number);
            var secondReplaced = FizzBuzzReplacerSecond(number);
            
            if (!string.IsNullOrEmpty(secondReplaced))
                result += string.IsNullOrEmpty(result)
                    ? secondReplaced
                    : "-" + secondReplaced;

            if (string.IsNullOrEmpty(result))
            {
                yield return number.ToString();
                continue;
            }

            yield return result;
        }
    }

    private static string FizzBuzzReplacerSecond(int number)
    {
        var result = "";
        if (number % 4 == 0) result += "muzz";

        if (number % 7 == 0)
        {
            if (!string.IsNullOrEmpty(result)) result += "-";
            result += "guzz";
        }

        return result;
    }

    /// <summary>
    ///     Если делится на 3 без остатка - заменить на "dog",
    ///     если делится на 5 без остатка - заменить на "cat,
    ///     если на 3 и 5 без остатка - заменить на "good-boy",
    ///     Если делится на 4 без остатка - заменить на "muzz",
    ///     если делится на 7 без остатка - заменить на "guzz",
    ///     если делится на 4 и 7 без остатка - заменить на "muzz-guzz".
    /// </summary>
    /// <param name="numbers">Список чисел</param>
    /// <returns>Обработанный список чисел с заменами</returns>
    public static IEnumerable<string> FizzBuzzThird(IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            var result = FizzBuzzReplacerThird(number);
            var secondReplaced = FizzBuzzReplacerSecond(number);
            
            if (!string.IsNullOrEmpty(secondReplaced))
                result += string.IsNullOrEmpty(result)
                    ? secondReplaced
                    : "-" + secondReplaced;

            if (string.IsNullOrEmpty(result))
            {
                yield return number.ToString();
                continue;
            }

            yield return result;
        }
    }

    private static string FizzBuzzReplacerThird(int number)
    {
        if (number % 3 == 0 && number % 5 == 0) return "good-boy";

        if (number % 3 == 0) return "dog";

        if (number % 5 == 0) return "cat";

        return "";
    }
}