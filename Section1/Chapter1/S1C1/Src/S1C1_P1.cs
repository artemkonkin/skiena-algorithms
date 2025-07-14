namespace S1C1;

public class S1C1_P1
{
    /// <summary>
    /// [3] Докажите, что значение a+b может быть меньшим, чем значение min(a,b).
    /// </summary>
    public void S1C1_P1_L1()
    {
        Console.WriteLine("[3] Докажите, что значение a+b может быть меньшим, чем значение min(a,b).");
    }

    /// <summary>
    /// [3] Докажите, что значение a*b может быть меньшим, чем значение min(a,b).
    /// </summary>
    public void S1C1_P1_L2()
    {
        Console.WriteLine("[3] Докажите, что значение a*b может быть меньшим, чем значение min(a,b).");
    }

    /// <summary>
    /// [3] Докажите правильность следующего рекурсивного алгоритма умножения двух натуральных чисел для всех целочисленных констант c >= 2:
    /// Multiply(y, z)
    ///    if z=0 then return (0) else
    /// return (Multiply(cy, floor(z/c)) + y*(z mod c))
    /// </summary>
    public void S1C1_P1_L8()
    {
        Console.WriteLine("[3] Докажите правильность следующего рекурсивного алгоритма умножения двух натуральных чисел для всех целочисленных констант c >= 2:");

        var c = 2;

        int Multiply(int y, int z)
        {
            if (z == 0)
            {
                Console.WriteLine($"z = {z}, y = {y}, c = {c}");

                return 0;
            }

            Console.WriteLine($"z = {z}, y = {y}, c = {c}");

            return Multiply(c * y, z / c) + y * (z % c);
        }

        for (c = 2; c < 4; c++)
        {
            for (var i = 2; i < 4; i++)
            {
                for (var j = 2; j < 4; j++)
                {
                    Console.WriteLine($"Multiply({i}, {j}) = {Multiply(i, j)} = {i * j}");

                    if (Multiply(i, j) != i * j)
                    {
                        throw new Exception();
                    }
                }
            }
        }
    }
}