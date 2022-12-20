/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/
Console.Clear();
//Метод возвращает количество десятков в ведённом пользователем числе.
int GetCountTen(int Number)
{
    int Count = 0;
    while (Number != 0)
    {
        Number = Number / 10;
        Count++;
    }
    return Count;
}
//Метод выводит на экран значение третьей цифры введённого числа или сообщает, что третьей цифры нет.
void ThirdDigit(int ProcessedNumber, int Order)
{
    if (Order < 3)
    {
        Console.WriteLine($"В числе {ProcessedNumber} нет третьей цифры");
    }
    else
    {
        int TenInDegree = (int)Math.Pow(10, (Order - 3));
        int NewNumber = ProcessedNumber / TenInDegree;
        int Digit = NewNumber % 10;
        if (Digit < 0)
        {
            Digit = Digit * (-1);
        }        
        Console.WriteLine($"В числе {ProcessedNumber}, третьей цифрой является цифра {Digit}");
    }
}
Console.Write("Введите число: ");
int EnterNumber = int.Parse(Console.ReadLine()!);
int CountTen = GetCountTen(EnterNumber);
ThirdDigit(EnterNumber, CountTen);