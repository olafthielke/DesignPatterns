using System;

namespace Patterns.Creational.AbstractFactory.CarMaker
{
    public class CarPlant
    {
        private CarProductionRun Run { get; }
        private Engine Engine { get; }
        private Fuel Fuel { get; }
        private FuelStorage FuelStorage { get; }


        public CarPlant(CarProductionRun run)
        {
            Run = run;

            Engine = Run.CreateEngine();
            Fuel = Run.CreateFuel();
            FuelStorage = Run.CreateFuelStorage();
        }

        public void Assemble()
        {
            // Assemble 'Electric Car' with 'Electric Motor' fueled by 'Electricity' stored in 'Battery'.
            // Assemble 'Regular Car' with 'Combustion Engine' fueled by 'Petrol' stored in 'Petrol Tank'.

            Console.WriteLine($"Assemble '{Run.Name}' with '{Engine.Name}' fueled by '{Fuel.Name}' stored in '{FuelStorage.Name}'.");
        }
    }
}
