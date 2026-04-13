internal class DeepCheckCar : CheckCar
{
    private double[] pressureWheels;

    public DeepCheckCar()
    {
        pressureWheels = new double[4] { 2.5, 2.5, 2.5, 2.5 };
    }
    public DeepCheckCar(double[] pressureWheels)
    {
        this.pressureWheels = pressureWheels;
    }
    public DeepCheckCar(bool engine, double[] pressureWheels)
    {
        BrokenEngine = engine;
        this.pressureWheels = pressureWheels;
    }

    public void CheckPressure()
    {
        int i;
        for (i = 0; i < pressureWheels.Length && !BrokenPressure; i++)
        {
            if (pressureWheels[i] != 2.5)
            {
                BrokenPressure = true;
            }
        }
    }
    public void Recomendation()
    {
        if (!IsBroken())
        {
            Console.WriteLine("Машина в порядке.");
        }
        else
        {
            Console.WriteLine("Машина сломана. РЕКОМЕНДАЦИИ:");
            if (BrokenEngine)
            {
                Console.WriteLine("Требуется ремонт двигателя!");
            }
            if (BrokenPressure)
            {
                for (int i = 0; i < pressureWheels.Length; i++)
                {
                    if (pressureWheels[i] < 2.5)
                    {
                        Console.WriteLine($"Колесо {i + 1}: Низкое давление ({pressureWheels[i]}). Подкачайте!");
                    }
                    else
                    {
                        if (pressureWheels[i] > 2.5)
                        {
                            Console.WriteLine($"Колесо {i + 1}: Избыточное давление ({pressureWheels[i]}). Спустите!");
                        }
                    }
                }
            }
        }
    }
}
