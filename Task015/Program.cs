/*Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.*/
Console.Clear();
//Метод возвращает случайно сгенерированный номер дня недели.
int GetDayWeek()
{
    int DigitDay = new Random().Next(1, 8);
    return DigitDay;
}
//Метод выводит на экран сообщение, является ли сгенерированный день недели выходным.
void WeekEnd(int Day)
{
    string DayWeek = "";
    switch (Day)
    {        
        case 1:
            DayWeek = "Понедельник";
            break;
        case 2:
            DayWeek = "Вторник";
            break;
        case 3:
            DayWeek = "Среда";
            break;
        case 4:
            DayWeek = "Четверг";
            break;
        case 5:
            DayWeek = "Пятница";
            break;
        case 6:
            DayWeek = "Суббота";
            break;
        case 7:
            DayWeek = "Воскресенье";
            break;
    }
    if (Day < 6)
    {
        Console.WriteLine($"{DayWeek} ({Day} день недели) - рабочий день");
    }
    else
    {
        Console.WriteLine($"{DayWeek} ({Day} день недели) - выходной день");
    }
}
Console.Write("Сколько раз проверить, является ли случайно выбранный день недели выходным? - ");
int Count = int.Parse(Console.ReadLine()!);
Console.WriteLine();
for (int i = 0; i < Count; i++)
{
    int RandomDay = GetDayWeek();
    Console.WriteLine($"Для проверки выбран {RandomDay} день недели");
    WeekEnd(RandomDay);  
    Console.WriteLine();  
}
