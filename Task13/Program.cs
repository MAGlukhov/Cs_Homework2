//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int numInt = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(numInt);

if(numText.Length > 2)
{
    Console.WriteLine(numText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}