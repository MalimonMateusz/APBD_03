namespace Containers;

public class GasContainer : Container, IHazardNotifier
 {
     private static int serialNum = 1;
     private double pressure;
  
     public GasContainer(double hight, double containerMass, double depth, double maximumLoad, double pressure) : base(hight, containerMass, depth, maximumLoad)
     {
         this.serialNumber = this.serialNumber + "G-" + serialNum;
         serialNum++;
         this.pressure = pressure;
     }
  
     public override void load(int load)
     {
         if(maximumLoad/2 >this.loadWeight + load){ hazard();}
         else
         {
             this.loadWeight += load;
         }
      
     }

     public override void dropLoad()
     {
         this.loadWeight = this.loadWeight * 0.05;
     }


     public void hazard()
  {
    Console.WriteLine("Hazard! " + this.serialNumber);    
  }


     public override void info()
     {
         base.info();
         Console.WriteLine("Pressure: " + pressure);
     }
 }