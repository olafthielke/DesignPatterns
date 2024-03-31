using System;
using Patterns.Creational.FactoryMethod.CarMaker.Engines;
using Patterns.Creational.FactoryMethod.CarMaker.PowerSources;

namespace Patterns.Creational.FactoryMethod.CarMaker
{
    public class PetrolCar
    {
        private Chassis Chassis { get; }
        private Motor Motor { get; }
        private EnergyStore EnergyStore { get; }
        private int NumberOfWheels { get; }

        public PetrolCar(Chassis chassis,
            Motor motor,
            EnergyStore energyStore,
            int numberOfWheels)
        {
            Chassis = chassis;
            Motor = motor;
            EnergyStore = energyStore;
            NumberOfWheels = numberOfWheels;
        }

        // ...


        public void Accelerate()
        {
            Console.WriteLine($"\tAccelerates from 0 to 100km/h in {Motor.SecondsTo100kmh} seconds.");
        }

        public void Drive()
        {
            Console.WriteLine($"\tDrive is {Motor.Sound} {Chassis} {EnergyStore} {NumberOfWheels}.");
        }

        public void Refuel()
        {
            //EnergyStore.Refuel();
        }
    }

    public class ElectricCar
    {
        private Chassis Chassis { get; }
        private Motor Motor { get; }
        private EnergyStore EnergyStore { get; }
        private int NumberOfWheels { get; }

        public ElectricCar(Chassis chassis,
            Motor motor,
            EnergyStore energyStore,
            int numberOfWheels)
        {
            Chassis = chassis;
            Motor = motor;
            EnergyStore = energyStore;
            NumberOfWheels = numberOfWheels;
        }



        public void Accelerate()
        {
            Console.WriteLine($"\tAccelerates from 0 to 100km/h in {Motor.SecondsTo100kmh} seconds.");
        }

        public void Drive()
        {
            Console.WriteLine($"\tDrive is {Motor.Sound} {Chassis} {EnergyStore} {NumberOfWheels}.");
        }

        public void Refuel()
        {
            //EnergyStore.Refuel();
        }
    }


    public class Car
    {
        private Chassis Chassis { get; }
        private Motor Motor { get; }
        private EnergyStore EnergyStore { get; }
        private int NumberOfWheels { get; }

        public Car(Chassis chassis,
            Motor motor,
            EnergyStore energyStore,
            int numberOfWheels)
        {
            Chassis = chassis;
            Motor = motor;
            EnergyStore = energyStore;
            NumberOfWheels = numberOfWheels;
        }


        public void Accelerate()
        {
            Console.WriteLine($"\tAccelerates from 0 to 100km/h in {Motor.SecondsTo100kmh} seconds.");
        }

        public void Drive()
        {
            Console.WriteLine($"\tDrive is {Motor.Sound} {Chassis} {EnergyStore} {NumberOfWheels}.");
        }

        public void Refuel()
        {
            //EnergyStore.Refuel();
        }
    }






    //public class Car
    //{
    //    private Chassis Chassis { get; }
    //    private Motor Motor { get; }
    //    private EnergyStore EnergyStore { get; }
    //    private int NumberOfWheels { get; }


    //    public Car(Chassis chassis, Motor motor, EnergyStore energyStore, int numberOfWheels)
    //    {
    //        Chassis = chassis;
    //        Motor = motor;
    //        EnergyStore = energyStore;
    //        NumberOfWheels = numberOfWheels;

    //        Console.WriteLine($"This car has been built with:");
    //        Console.WriteLine($"\tChassis: {Chassis.Type}");
    //        Console.WriteLine($"\tMotor: {Motor.Type}");
    //        Console.WriteLine($"\tEnergy Store: {EnergyStore.Type}");
    //        Console.WriteLine($"\tNumber Of Wheels: {NumberOfWheels}");
    //        Console.WriteLine();
    //    }


    //    public void Accelerate()
    //    {
    //        Console.WriteLine($"\tAccelerates from 0 to 100km/h in {Motor.SecondsTo100kmh} seconds.");
    //    }

    //    public void Drive()
    //    {
    //        Console.WriteLine($"\tDrive is {Motor.Sound}.");
    //    }

    //    public void Refuel()
    //    {
    //        EnergyStore.Refuel();
    //    }
    //}
}
