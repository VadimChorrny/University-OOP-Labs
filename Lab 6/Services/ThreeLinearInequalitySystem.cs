namespace Lab_6.Services;

// Клас "Система трьох лінійних нерівностей"
public class ThreeLinearInequalitySystem : LinearInequalitySystem
{
    public ThreeLinearInequalitySystem() : base(3)
    {
    }

    // Перевизначений метод для перевірки системи трьох нерівностей
    public override bool IsSatisfied(double[] vector)
    {
        if (vector.Length != coefficients.Length)
        {
            Console.WriteLine("Розмірність вектора не відповідає розмірності системи трьох нерівностей.");
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

    // Віртуальний метод деструктору
    ~ThreeLinearInequalitySystem()
    {
        Console.WriteLine("Об'єкт ThreeLinearInequalitySystem знищений.");
    }
}