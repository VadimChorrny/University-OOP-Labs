namespace Lab_6.Services;

// Абстрактний клас "Система лінійних нерівностей"
public abstract class LinearInequalitySystem
{
    protected double[] coefficients;

    protected LinearInequalitySystem(int variableCount)
    {
        coefficients = new double[variableCount];
    }

    // Абстрактний метод для перевірки, чи введений вектор задовольняє системі нерівностей
    public abstract bool IsSatisfied(double[] vector);

    // Реалізований метод для встановлення коефіцієнтів нерівностей
    public void SetCoefficients(params double[] coeffs)
    {
        if (coeffs.Length == coefficients.Length)
        {
            for (int i = 0; i < coeffs.Length; i++)
            {
                coefficients[i] = coeffs[i];
            }
        }
        else
        {
            Console.WriteLine("Кількість коефіцієнтів не відповідає кількості змінних.");
        }
    }

    // Реалізований метод для виведення коефіцієнтів на екран
    public void DisplayCoefficients()
    {
        Console.Write("Коефіцієнти: ");
        foreach (double coeff in coefficients)
        {
            Console.Write(coeff + " ");
        }
        Console.WriteLine();
    }

    // Віртуальний метод деструктору
    ~LinearInequalitySystem()
    {
        Console.WriteLine("Об'єкт LinearInequalitySystem знищений.");
    }
}