# Тестовое задание Флексибейс для .Net-джуна

Решение состоит из двух проектов: библиотеки с требуемым функционалом и тестами. Тесты автоматически запускаются в GitHub Action для простоты проверки.

## Задание:

> 1. Напишите программу, которая будет принимать на вход список чисел, а выводить тот же список чисел, но с заменами. **Использовать ООП и SOLID, написать тесты.**
>
>    Если число делится на 3 без остатка - заменить его на "fizz", если делится на 5 без остатка - заменить его на "buzz", если делится на 3 и на 5 без остатка - заменить на "fizz-buzz"
>
>    >  In: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
>
>    >  Out: 1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz
>
>    2. На основе первой задачи. Нужно добавить аналогичное поведения для чисел кратным 7 и 4. Если делится на 4 без остатка - заменить на "muzz", если делится на 7 без остатка - заменить на "guzz", если делится на 4 и 7 без остатка - заменить на "muzz-guzz".
>
>    
>    Аналогичное поведения для всех комбинаций чисел при кратности.
>    Пример: число 105 кратно 3, 5, 7 и не кратно 4 - его нужно заменить на "fizz-buzz-guzz"
>
>    In:
>
>    > 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420
>
>    Out:
>
>    > 1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz
>
>    3. Измените поведение для деления без остатка на 3 и 5. Если делится на 3 без остатка - заменить на "dog", если делится на 5 без остатка - заменить на "cat, если на 3 и 5 без остатка - заменить на "good-boy".
>    При кратности на 3 и 5 и другие числа - "good-boy" выводить вначале замены.
>
>    In:
>
>    > 1, 2, 3,  4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420
>
>    Out:
>
>    > 1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, fizz-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz
