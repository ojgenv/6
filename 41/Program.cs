/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.WriteLine("введите M чисел через пробел");
string[] digits = GetDigits();
Console.WriteLine($"Чисел больше 0 - {FindPositiveDigits(digits)}");

string[] GetDigits()
{
    string? text = Console.ReadLine();
    return text.Split(' ');
}

int FindPositiveDigits(string[] digits)
{
    int positiveDigits = 0;
    foreach (string digit in digits)
    {
        int num = Convert.ToInt32(digit);
        if (num > 0)
        {
            positiveDigits += 1;
        }
    }
    return positiveDigits;
}