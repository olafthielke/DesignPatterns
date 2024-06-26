﻿using Patterns.Creational.FactoryMethod.CarMaker.Engines;
using Patterns.Creational.FactoryMethod.CarMaker.PowerSources;

namespace Patterns.Creational.FactoryMethod.CarMaker.Factories
{
    //public class ElectricCarFactory
    //{
    //    public ElectricCar Assemble()
    //    {
    //        var chassis = new Chassis();
    //        var motor = new ElectricMotor();
    //        var batteries = new BatteryArray();
    //        var numberOfWheels = 4;

    //        return new ElectricCar(chassis, 
    //            motor, 
    //            batteries, 
    //            numberOfWheels);
    //    }
    //}







    public class ElectricCarFactory : CarFactory
    {
        protected override Motor MakeMotor()
        {
            return new ElectricMotor();
        }

        protected override EnergyStore MakeEnergyStore()
        {
            return new BatteryArray();
        }
    }
}
