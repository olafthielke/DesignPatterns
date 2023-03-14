using System;
using System.Collections.Generic;
using System.Net.Http;
using Patterns.Behavioural.ChainOfResponsibility.Handlers;
using Patterns.Behavioural.ChainOfResponsibility.Incidents;
using Patterns.Behavioural.NullObject;
using Patterns.Behavioural.TemplateMethod;
using Patterns.Creational.AbstractFactory.SalesTax.EvenBetter;
using Patterns.Creational.Builder.Employment;
using Patterns.Creational.FactoryMethod.CarMaker.Factories;
using Patterns.Creational.Monostate;
using Patterns.Creational.Singleton;
using Patterns.Structural.Decorator.Barista;
using Patterns.Structural.Decorator.Barista.Coffees;
using Patterns.Structural.Decorator.Logging;
using Patterns.Structural.Facade;
using Patterns.Structural.Facade.Entities;
using Patterns.Structural.Facade.File;
using Patterns.Structural.Facade.Interfaces;
using Patterns.Structural.Facade.Redis;
using Patterns.Structural.Facade.Sql;
using Patterns.Structural.HumbleObject;
using Customer = Patterns.Structural.Facade.Entities.Customer;

namespace PatternRunner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunCreationalDesignPatterns();
            //RunStructuralDesignPatterns();
            RunBehaviouralDesignPatterns();

            Console.ReadLine();
        }

        #region Creational Design Patterns

        private static void RunCreationalDesignPatterns()
        {
            RunFactoryMethod();
            //RunAbstractFactory();
            //RunSingleton();
            //RunMonostate();
            //RunBuilder();
        }

        #region Factory Method

        private static void RunFactoryMethod()
        {
            // Pick the type of car factory we want:

            var electricCarFactory = new ElectricCarFactory();
            var electricCar = electricCarFactory.Make();

            electricCar.Accelerate();
            electricCar.Drive();
            electricCar.Refuel();

            Console.WriteLine("\t------------------------------------");
            Console.WriteLine();

            // -------------------------------------------------

            var petrolCarFactory = new PetrolEngineCarFactory();
            var petrolCar = petrolCarFactory.Make();

            petrolCar.Accelerate();
            petrolCar.Drive();
            petrolCar.Refuel();

            Console.WriteLine("\t------------------------------------");
            Console.WriteLine();

            // -------------------------------------------------

            var dieselCarFactory = new DieselEngineCarFactory();
            var dieselCar = dieselCarFactory.Make();

            dieselCar.Accelerate();
            dieselCar.Drive();
            dieselCar.Refuel();

            Console.WriteLine("\t------------------------------------");
            Console.WriteLine();
        }

        #endregion

        #region Abstract Factory

        private static void RunAbstractFactory()
        {
            var salesTaxSelector = new Patterns.Creational.AbstractFactory.SalesTax.EvenBetter.SalesTaxSelector(new NewZealandGst(), new UnitedKingdomVat());

            var country = "New Zealand";
            var tax = salesTaxSelector.Select(country);
            Console.WriteLine($"The sales tax in {country} is called {tax.TaxName} and is {tax.TaxRate:P0}");

            Console.WriteLine();

            country = "United Kingdom";
            tax = salesTaxSelector.Select(country);
            Console.WriteLine($"The sales tax in {country} is called {tax.TaxName} and is {tax.TaxRate:P0}");
        }

        #endregion

        #region Singleton

        private static void RunSingleton()
        {
            //RunSimpleSingleton();

            RunSqlConnectionSingleton();
        }

        private static void RunSimpleSingleton()
        {
            Console.WriteLine("Simple Singleton Example:");
            Console.WriteLine();

            var singleton = SimpleSingleton.GetInstance();
            var anotherReference = SimpleSingleton.GetInstance();
            //var anotherReference = new SimpleSingleton();

            singleton.Data = "abc";
            Console.WriteLine($"Set singleton.Data to '{singleton.Data}'");
            Console.WriteLine();
            Console.WriteLine($"Get singleton.Data: {singleton.Data}");
            Console.WriteLine($"Get anotherReference.Data: {anotherReference.Data}");

            Console.WriteLine();

            anotherReference.Data = "xyz";
            Console.WriteLine($"Set anotherReference.Data to '{anotherReference.Data}'");
            Console.WriteLine();
            Console.WriteLine($"Get singleton.Data: {singleton.Data}");
            Console.WriteLine($"Get anotherReference.Data: {anotherReference.Data}");

            Console.WriteLine();

            // For a Singleton, will it be the same instance or a different one?
            if (singleton.Equals(anotherReference))
                Console.WriteLine("Same instance");
            else
                Console.WriteLine("Different instance");
        }

        private static void RunSqlConnectionSingleton()
        {
            Console.WriteLine("SQL Singleton Example:");
            Console.WriteLine();

            // Singleton
            var database = SqlConnectionSingleton.GetInstance();

            var customer1 = database.GetCustomer(1);
            LogCustomer(customer1);

            // Singleton
            var databaseToo = SqlConnectionSingleton.GetInstance();

            var customer2 = databaseToo.GetCustomer(2);
            LogCustomer(customer2);

            database.Dispose();
        }

        private static void LogCustomer(Patterns.Creational.Customer customer)
        {
            Console.WriteLine($"Got Customer with Id: '{customer.CustomerId}' called {customer.FirstName} {customer.LastName}");
        }

        #endregion

        #region Monostate

        private static void RunMonostate()
        {
            RunSimpleMonostate();

            //RunSqlConnectionMonostate();
        }

        private static void RunSimpleMonostate()
        {
            Console.WriteLine("Simple Monostate Example:");
            Console.WriteLine();

            var monostate1 = new SimpleMonostate();
            var monostate2 = new SimpleMonostate();

            monostate1.Data = "hello";
            Console.WriteLine($"Set monostate1.Data to '{monostate1.Data}'");
            Console.WriteLine();
            Console.WriteLine($"Get monostate1.Data: {monostate1.Data}");
            Console.WriteLine($"Get monostate2.Data: {monostate2.Data}");

            Console.WriteLine();

            monostate2.Data = "world!";
            Console.WriteLine($"Set monostate2.Data to '{monostate2.Data}'");
            Console.WriteLine();
            Console.WriteLine($"Get monostate2.Data: {monostate2.Data}");
            Console.WriteLine($"Get monostate1.Data: {monostate1.Data}");

            Console.WriteLine();

            // For a Monostate, will it be the same instance or a different one?
            if (monostate1.Equals(monostate2))
                Console.WriteLine("Same instance");
            else
                Console.WriteLine("Different instance");
        }

        private static void RunSqlConnectionMonostate()
        {
            Console.WriteLine("SQL Monostate Example:");
            Console.WriteLine();

            // Monostate
            var database = new SqlConnectionMonostate();

            var customer1 = database.GetCustomer(1);
            LogCustomer(customer1);

            var databaseToo = new SqlConnectionMonostate();

            var customer2 = databaseToo.GetCustomer(2);
            LogCustomer(customer2);

            database.Dispose();
        }

        #endregion

        #region Builder

        private static void RunBuilder()
        {
            RunEmployment();
        }

        private static void RunEmployment()
        {
            // Worker
            var worker = new WorkerBuilder().Build(25, 40);
            var weeklyWorkerPay = worker.NextPayAmount();

            Console.WriteLine("Worker:");
            Console.WriteLine($"\tNext Weekly Pay: ${weeklyWorkerPay:F2}");
            Console.WriteLine($"\tWorker Perks: {worker.Perks.Count}");

            Console.WriteLine();

            // Salaried Manager
            var salariedManager = new SalariedManagerBuilder().Build(80000);
            var monthlyManagerPay = salariedManager.NextPayAmount();

            Console.WriteLine("Salaried Manager:");
            Console.WriteLine($"\tNext Monthly Pay: ${monthlyManagerPay:F2}");
            Console.WriteLine($"\tManager Perks: {salariedManager.Perks.Count}");
            foreach (var perk in salariedManager.Perks)
            {
                Console.WriteLine($"\t\tPerk: {perk.Name}");
            }

            Console.WriteLine();

            // Hourly Manager
            var hourlyManager = new HourlyManagerBuilder().Build(60, 30);
            var weeklyManagerPay = hourlyManager.NextPayAmount();

            Console.WriteLine("Hourly Manager:");
            Console.WriteLine($"\tNext Weekly Pay: ${weeklyManagerPay:F2}");
            Console.WriteLine($"\tHourly Manager Perks: {hourlyManager.Perks.Count}");
            foreach (var perk in hourlyManager.Perks)
            {
                Console.WriteLine($"\t\tPerk: {perk.Name}");
            }
        }

        #endregion

        #endregion

        #region Structural Design Patterns

        private static void RunStructuralDesignPatterns()
        {
            RunFacade();
            //RunDecorator();
            //RunHumbleObject();
        }

        #region Facade

        private static void RunFacade()
        {
            var repo = SetupCustomerRepositoryFacade();
            var useCase = new GetCustomerUseCase(repo);

            var customer = useCase.GetCustomer(1).Result;
            LogCustomer(customer);
        }

        private static void LogCustomer(Customer customer)
        {
            Console.WriteLine();
            Console.WriteLine("Facade");
            Console.WriteLine("Log Customer:");
            Console.WriteLine($"{customer}");
        }

        private static ICustomerRepository SetupCustomerRepositoryFacade()
        {
            var detailsRepo = new SqlCustomerDetailsRepository();
            var addressRepo = SetupRedisCustomerAddressRepository();
            var loyaltyRepo = new FileCustomerLoyaltyRepository();

            return new CustomerRepositoryFacade(detailsRepo, addressRepo, loyaltyRepo);
        }

        private static ICustomerAddressRepository SetupRedisCustomerAddressRepository()
        {
            var config = new RedisConfiguration();
            var connector = new RedisConnector(config);
            var repo = new RedisCustomerAddressRepository(connector);
            SaveTestCustomerAddress(repo);
            return repo;
        }

        private static void SaveTestCustomerAddress(ICustomerAddressRepository addressRepo)
        {
            var customerAddress = new CustomerAddress
            {
                CustomerId = 1,
                StreetNumber = "37A",
                StreetName = "Granite Street",
                Suburb = "Rockbottom",
                TownOrCity = "Rockwell",
                Country = "Stone Age",
                PostCode = 1234
            };
            addressRepo.SaveAddress(customerAddress);
        }

        #endregion

        #region Decorator

        private static void RunDecorator()
        {
            //RunCoffeeDecorator();

            RunLoggerDecorator();
        }

        private static void RunCoffeeDecorator()
        {
            Log(new Espresso());
            Log(new WhippedCream(new Espresso()));
            Log(new Cherry(new WhippedCream(new Espresso())));
            Log(new ChocolatePowder(new Cherry(new WhippedCream(new Mocha()))));
            Log(new Cherry(new ChocolatePowder(new Cherry(new WhippedCream(new FlatWhite())))));
        }

        private static void Log(Coffee coffee)
        {
            Console.WriteLine($"Your coffee is {coffee.Description}, costing ${coffee.Cost}.");
        }

        private static void RunLoggerDecorator()
        {
            var logger1 = new Patterns.Structural.Decorator.Logging.ConsoleLogger();
            logger1.Log("Only logging to console.");

            var logger2 = new DebugToFileLogger(new Patterns.Structural.Decorator.Logging.ConsoleLogger());
            logger2.Log("Logging to file and console.").Wait();
        }

        #endregion

        #region Humble Object

        private static void RunHumbleObject()
        {
            var analyser = new SiteAnalyser(new HttpClient());

            var contentSize = analyser.GetContentSize("http://microsoft.com").Result;
        }

        #endregion

        #endregion

        #region Behavioural Design Patterns

        private static void RunBehaviouralDesignPatterns()
        {
            //RunNullObject();
            //RunTemplateMethod();
            RunChainOfResponsibility();
        }

        private static void RunNullObject()
        {
            var obj = new ClassThatDoesSomeStuff(new Patterns.Behavioural.NullObject.DoNotLogger());

            var result = obj.DoSomeStuff(2, 3);
        }

        private static void RunTemplateMethod()
        {
            // Get VIP Customers
            var vipMiner = new VipCustomerMiner();
            var vipCustomers = vipMiner.MineCustomers();
            Log("VIP Customers:", vipCustomers);

            // Get Standard Customers
            var miner = new StandardCustomerMiner();
            var customers = miner.MineCustomers();
            Log("Standard Customers:", customers);
        }

        private static void Log(string heading, IList<Patterns.Behavioural.TemplateMethod.Customer> customers)
        {
            Console.WriteLine();
            Console.WriteLine(heading);
            foreach (var customer in customers)
                Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}, Email: {customer.EmailAddress}");
        }

        private static void RunChainOfResponsibility()
        {
            // Setup Chain of Responsibility
            var handler = new TradeRepresentative(
                new Undersecretary(
                    new ChiefOfStaff(
                        new ThePresident())));

            Console.WriteLine("Trade Dispute:");
            handler.Handle(new TradeDispute());
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Tariff Negotiation:");
            handler.Handle(new TariffNegotiation());
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Border Skirmish:");
            handler.Handle(new BorderSkirmish());
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("UN Resolution:");
            handler.Handle(new UNResolution());
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("War:");
            handler.Handle(new War());
        }

        #endregion
    }
}
