/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/
Console.Clear();
//Метод генерирует случайное трёхзначное число. Число может быть, как положительным, так и отрицательным.
int GetNumberFromRange(int start, int end)
{
    int key = 0;
    int NewNumber = 0;
    do
    {
        NewNumber = new Random().Next(start, end+1) - end / 3;        
        key =  NewNumber / 100;       
    } while (key == 0);  
    return NewNumber; 
}
//Метод возвращает значение второй цифры, сгенерированного числа.
int GetSecondDigit(int number)
{
    if (number < 0)
    {
        number = number * (-1);        
    }
    number = number / 10;
    number = number % 10;
    return number;
}
Console.Write("Введите количество случайных чисел, которое надо сгенерировать: ");
int count = int.Parse(Console.ReadLine()!);
for (int i = 0; i < count; i++)
{
    int RandomNumber = GetNumberFromRange(100, 999);
    int SecondDigit = GetSecondDigit(RandomNumber);
    Console.WriteLine($"В сгенерированном числе {RandomNumber}, второй цифрой является цифра {SecondDigit}");   
}

