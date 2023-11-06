// See https://aka.ms/new-console-template for more information

using Lab_5.Services;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Лабораторна робота №5 ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Виконав студент групи ІПЗ-22, Чорний Вадим Олександрович\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(
    "Різниця між 4 та 5 лаборатоною роботою, в тому що в 5 лабораторній роботі використовується поліморфізм\n" +
    "та демонструється робота віртуальних методів, коли наперед невідомо який об'єкт буде створено (на етапі компіляції)\n");

Console.ResetColor();

// Створення об'єкта системи трьох лінійних нерівностей
LinearInequalitySystem system = new ThreeLinearInequalitySystem();
system.SetCoefficients(1, 2, 2);
system.DisplayCoefficients();

double[] userVector = { 2, 3, 4 }; // задовільниний вектор
double[] userVector_false = { 2, 3, 1 }; // незадовільниний вектор

// Використання віртуального методу IsSatisfied, навіть коли ми маємо посилання на базовий клас,
// демонструє поліморфізм, оскільки викликати буде перевизначений метод з похідного класу,
// інкапсулюючи логіку перевірки системи нерівностей, навіть коли об'єкт змінюється
bool isSatisfied = system.IsSatisfied(userVector);

if (isSatisfied)
{
    Console.Write("Система трьох нерівностей:");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(" Задовільниний вектор");
    Console.ResetColor();
}
else
{
    Console.Write("Система трьох лінійних нерівностей:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" Незадовільниний вектор");
    Console.ResetColor();
}