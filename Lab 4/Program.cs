// See https://aka.ms/new-console-template for more information

using Lab_4.Services;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Лабораторна робота №4 ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Виконав студент групи ІПЗ-22, Чорний Вадим Олександрович\n");
Console.ResetColor();

// Створення об'єкта системи трьох лінійних нерівностей
ThreeLinearInequalitySystem system3 = new ThreeLinearInequalitySystem();
system3.SetCoefficients(1, 2, 2);
system3.DisplayCoefficients();

double[] userVector3 = { 2, 3, 4 }; // задовільниний вектор
double[] userVector3_false = { 2, 3, 1 }; // незадовільниний вектор
bool isSatisfied = system3.IsSatisfied(userVector3_false);

if (isSatisfied)
{
    Console.Write("Система трьох нерівностей:");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(" Задовільниний вектор");
    Console.ResetColor();
}
else
{
    Console.Write("Система трьох нерівностей:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" Незадовільниний вектор");
    Console.ResetColor();
}