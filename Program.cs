// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Этот код примет координаты двух точек в трехмероном пространстве и рассчитает расстояние между ними. Введите координату по оси Х первой точки:");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату по ости Y первой точки:");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату по ости Z первой точки:");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату по ости X второй точки:");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату по ости Y второй точки:");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату по ости Z второй точки:");
int Z2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между этими точками равно {(Math.Sqrt(Math.Pow((X1-X2), 2) + Math.Pow((Y1-Y2),2)+ Math.Pow((Z1-Z2),2))):f2}");
