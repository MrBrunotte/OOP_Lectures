using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExample
{
    class Vehicle
    {
        public string RegNo { get; set; }
        public Vehicle(string regNo)
        {
            RegNo = regNo;
        }
        // virtual so that we can override it
        public virtual string Drive(double distance) => distance > 0 ? $"Vehicle wants to drive for {distance}" : "Error message";
    }

    class FuelVehicle : Vehicle
    {
        private double fuelLevel;
        public double FuelCapacity { get; }
        public double FuelLevel
        {
            get
            {
                return fuelLevel;       // returns the fuelLevel
            }
            set
            {
                double newLevel = Math.Max(0, value);           // Max tar det största värde av 0, value
                fuelLevel = Math.Min(newLevel, FuelCapacity);   // Min tar det minsta värdet av newLevel och FuelCapacity
            }
        }

        // Constructor for FuelVehicle with two parameters and the base class constructor in base(regNo)
        public FuelVehicle(string regNo, double fuelCapacity) : base(regNo)
        {
            FuelCapacity = fuelCapacity;
        }
    }
    class FuelCar : FuelVehicle
    {
        private const double fuelConsumption = 0.5;
        public double maxDistance => FuelLevel / fuelConsumption; // är samma som en get {return = value;)
        public double Milage { get; private set; }
        public FuelCar(string regNo, double fuelCapacity): base(regNo, fuelCapacity)
        {
        }
        // overrides the Drive method from the base class
        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }
    }

}
