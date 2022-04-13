Auto audi = new ();

audi.Model = "Audi A6";
audi.YearOfBuild = 2007;
audi.EngineCapacity = 3.00;

audi.Print();


Auto bmw = new ();

bmw.Model = "BMW E3";
bmw.YearOfBuild = 2009;
bmw.EngineCapacity = 2.00;

bmw.Print();


Auto lada = new ();

lada.Model = "Lada Kalina";
lada.YearOfBuild = 2022;
lada.EngineCapacity = 5.5;

lada.Print();


Auto vzhuch = new ();

vzhuch.Model = "VZHUCH YAM";
vzhuch.YearOfBuild = 1137;
vzhuch.EngineCapacity = 0.5;

vzhuch.Print();


Auto.CountModel();



class Auto
{
    public static int count = 0;

    private string? model;
    private int yearOfBuild;
    private double engineCapacity;

    public string Model
    {
        get
        {
            return model;
        }

        set
        {
            model = value;
        }
    }

    public int YearOfBuild
    {
        get
        {
            return yearOfBuild;
        }


        set
        {
            yearOfBuild = value;
        }

    }
    
    public double EngineCapacity
    {
        get
        {
            return engineCapacity;
        }
        set
        {
            engineCapacity = value;
        }

    }


    public Auto()
    {
        count++;
    }


    public void Print()
    {
        string engine = string.Format("{0:f1}",engineCapacity);
        Console.WriteLine($"Model: {model}, Year of build: {yearOfBuild}, Engine capacity: {engine}");
    }

    public static void CountModel()

    {
        Console.WriteLine("Quantity of the models are " + count);
    }
    
}