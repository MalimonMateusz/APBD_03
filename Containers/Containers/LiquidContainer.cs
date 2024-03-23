namespace Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private static int serialNum = 1;
    private Boolean hazardous = false;

    public LiquidContainer(double hight, double containerMass, double depth, double maximumLoad) :
        base(hight,
            containerMass, depth, maximumLoad)
    {
        this.serialNumber = this.serialNumber + "L-" + serialNum;
        serialNum++;
    }

    protected override void load(int load)
    {
        Console.WriteLine("Is the stuff hazardous, type YES or NO");
        String hazardouss = Console.ReadLine();
        if (hazardouss.Equals("YES")) this.hazardous = true;
        if (hazardous)
        {
            if (maximumLoad / 2 < this.loadWeight + load)
            {
                hazard();
            }
            else
            {
                this.loadWeight += load;
            }
        }
        else
        {
            if (maximumLoad * 0.9 < this.loadWeight + load)
            {
                hazard();
            }

            else
            {
                this.loadWeight += load;
            }
        }
    }


    protected override void dropLoad()
    {
        base.dropLoad();
        this.hazardous = false;
    }

    public void hazard()
    {
        Console.WriteLine("Hazard! " + this.serialNumber);
    }
}