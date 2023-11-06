// See https://aka.ms/new-console-template for more information

using Lab_6.Services;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Лабораторна робота №6 ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Виконав студент групи ІПЗ-22, Чорний Вадим Олександрович\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(
    "Різниця між 5 та 6 лаборатоною роботою, в тому що в 6 лабораторній роботі використовується абстрактний клас\n" +
    "та демонструється робота абстрактних методів, коли наперед невідомо який об'єкт буде створено (на етапі компіляції)\n");


Console.ResetColor();

// Створення об'єкта системи трьох лінійних нерівностей
LinearInequalitySystem system = new ThreeLinearInequalitySystem();
system.SetCoefficients(1, 2, 2);
system.DisplayCoefficients();

double[] userVector = { 2, 3, 4 }; // задовільний вектор
double[] userVector_false = { 2, 3, 1 }; // незадовільний вектор

// Використання абстрактного методу IsSatisfied для об'єкта, 
// який створений як базовий клас, викликає перевизначений метод з похідного класу,
// ілюструючи поліморфізм при роботі з абстрактним класом
bool isSatisfied = system.IsSatisfied(userVector_false);

if (isSatisfied)
{
    Console.Write("Система трьох нерівностей:");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(" Задовільний вектор");
    Console.ResetColor();
}
else
{
    Console.Write("Система трьох лінійних нерівностей:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" Незадовільний вектор");
    Console.ResetColor();
}