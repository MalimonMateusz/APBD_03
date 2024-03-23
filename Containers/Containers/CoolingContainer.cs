namespace Containers;

public class CoolingContainer : Container
{
    private static int serialNum = 1;
    private Dictionary<string, double> products = new Dictionary<string, double>();
    private double temperature;
    private String product = "None";

    public CoolingContainer(double hight, double containerMass, double depth, double maximumLoad, double temperature) :
        base(hight,
            containerMass, depth, maximumLoad)
    {
        this.serialNumber = this.serialNumber + "C-" + serialNum;
        serialNum++;
        this.temperature = temperature;
        products = productDictionary(products);
    }

    public override void dropLoad()
    {
        base.dropLoad();
        this.product = "None";
    }

    public override void load(int load)
    {
        Console.WriteLine("Pick product to load:");
        Console.WriteLine();
        foreach (var key in this.products)
        {
            Console.WriteLine(key);
        }

        Console.Write("Insert name of the product: ");
        String prod = Console.ReadLine();
        foreach (String key in this.products.Keys)
        {
            if (prod.Equals(key))
            {
                if (this.products[key] > this.temperature)
                {
                    if (this.product.Equals(key) || this.product.Equals("None"))
                    {
                        this.product = key;
                        base.load(load);
                    }
                    else
                    {
                        Console.WriteLine("You can only store one type of product in one container!");
                    }
                }
                else
                {
                    Console.WriteLine("This container does not meet temperature requirements for this product!");
                }
            }
            else
            {
                Console.WriteLine("This product is not on a list!");
            }
        }
    }


    public override void info()
    {
        base.info();
        Console.WriteLine("Temperature: " + temperature);
        Console.WriteLine("Product: " + product);
    }


    //Lista produktów
    private Dictionary<string, double> productDictionary(Dictionary<string, double> a)
    {
        a["Bananas"] = 13.3;
        a["Chocolate"] = 18;
        a["Fish"] = 2;
        a["Meat"] = -15;
        a["Ice Cream"] = -18;
        a["Frozen pizza"] = -30;
        a["Cheese"] = 7.2;
        a["Sausages"] = 5;
        a["Butter"] = 20.5;
        a["Eggs"] = 19;
        return a;
    }
}