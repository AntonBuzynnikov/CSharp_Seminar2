// 27. Найти расстояние между точками в пространстве 2D
System.Console.Write("Введите X1: ");
int x1 = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введите Y1: ");
int y1 = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введите X2: ");
int x2 = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введите Y2: ");
int y2 = Int32.Parse(System.Console.ReadLine());
double distance;
distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
System.Console.WriteLine($"Растояния между точками {x1};{y1} и {x2};{y2} = {distance}");