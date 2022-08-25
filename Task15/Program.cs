// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void CheckWeekendOrNot(int day)
{
    if(day > 5 && day <= 7)
    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Это не выходной");
    }
}

Console.WriteLine("Введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber < 8 && dayNumber > 0)
{
CheckWeekendOrNot(dayNumber);
}
else
{
    Console.WriteLine("В неделе 7 дней с 1 по 7, дурень!");
}