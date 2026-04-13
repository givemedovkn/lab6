internal class CheckCar
{
    private bool brokenEngine;
    private bool brokenPressure;

    public CheckCar()
    {
        brokenEngine = false;
        brokenPressure = false;
    }
    public CheckCar(bool brokenEngine, bool brokenPressure)
    {
        this.brokenEngine = brokenEngine;
        this.brokenPressure = brokenPressure;
    }
    public CheckCar(CheckCar car)
    {
        this.brokenEngine = car.brokenEngine;
        this.brokenPressure = car.brokenPressure;
    }
    public bool BrokenEngine
    {
        get 
        { 
            return brokenEngine; 
        }
        set 
        { 
            brokenEngine = value; 
        }
    }
    public bool BrokenPressure
    {
        get
        {
            return brokenPressure;
        }
        set
        {
            brokenPressure = value;
        }
    }
    public bool IsBroken()
    {
        return (brokenEngine || brokenPressure);
    }
    public override string ToString()
    {
        return $"Двигатель сломан: {brokenEngine}," +
            $" Нарушение давления: {brokenPressure}";
    }
}
