namespace Containers;

public class Container : IHazardNotifier
{
    public double loadWeight = 0;
    public double hight;
    public double containerMass;
    public double depth;
    public String serialNumber = "KON-";
    public double maximumLoad;


    protected Container(double hight, double containerMass, double depth, double maximumLoad)
    {
        this.hight = hight;
        this.containerMass = containerMass;
        this.depth = depth;
        this.maximumLoad = maximumLoad;
    }

     public virtual void dropLoad()
    {
        loadWeight = 0;
    }

   public virtual void load(int load)
    {
        if (maximumLoad*0.9 < this.loadWeight + load){
            hazard();
}
        else
        {
            this.loadWeight += load;
        }
       
        
    }


    public virtual void info()
    {
        Console.WriteLine("Serial Number: " + serialNumber);
        Console.WriteLine();
        Console.WriteLine("Height: " + hight);
        Console.WriteLine("Load Weight: " + loadWeight);
        Console.WriteLine("Depth: " + depth);
        Console.WriteLine("Maximum Load: " + maximumLoad);
        Console.WriteLine("Container Mass: "  + containerMass);
       
        
    }


    public void hazard()
    {
        Console.WriteLine("Hazard! " + this.serialNumber);
    }

    public double LoadWeight
    {
        get => loadWeight;
        set => loadWeight = value;
    }

    public double Hight
    {
        get => hight;
        set => hight = value;
    }

    public double ContainerMass
    {
        get => containerMass;
        set => containerMass = value;
    }

    public double Depth
    {
        get => depth;
        set => depth = value;
    }

    public string SerialNumber
    {
        get => serialNumber;
        set => serialNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double MaximumLoad
    {
        get => maximumLoad;
        set => maximumLoad = value;
    }
}