//20. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
System.Console.Write("Введите число: ");
int a = Int32.Parse(System.Console.ReadLine());
if (a == 6 || a == 7) System.Console.WriteLine("Выходной");
else
{
    if (a >= 1 && a <= 5) System.Console.WriteLine("Будний день");
    else System.Console.WriteLine($"{a} не является днём недели");
}