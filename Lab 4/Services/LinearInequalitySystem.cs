namespace Lab_4.Services;

// Базовий клас "Система лінійних нерівностей"
public class LinearInequalitySystem
{
    protected double[] coefficients;
    public LinearInequalitySystem(int variableCount)
    {
        coefficients = new double[variableCount];
    }

    // Метод для встановлення коефіцієнтів нерівностей
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

    // Метод для виведення коефіцієнтів на екран
    public void DisplayCoefficients()
    {
        Console.Write("Коефіцієнти: ");
        foreach (double coeff in coefficients)
        {
            Console.Write(coeff + " ");
        }
        Console.WriteLine();
    }

    // Метод для перевірки, чи введений вектор задовольняє системі нерівностей
    public virtual bool IsSatisfied(double[] vector)
    {
        if (vector.Length != coefficients.Length)
        {
            Console.WriteLine("Розмірність вектора не відповідає розмірності системи нерівностей.");
            return false;
        }

        for (int i = 0; i < coefficients.Length; i++)
        {
            if (vector[i] < coefficients[i])
            {
                return false;
            }
        }

        return true;
    }
}
