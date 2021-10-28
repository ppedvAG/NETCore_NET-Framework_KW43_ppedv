using System;

namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService service = new CarService(); 

            ICar mockCar = new MockCar();
            service.RepairCar(mockCar);

            //Nach Tag 5
            service.RepairCar(new Car());

        }
    }

    #region BadCode -> Projektdauer 8 Tage 
    public class BadCar // Programmierer A: 5 Tage
    {
        public int Id { get; set; } 
        public string Model { get; set; }    
        public string Brand { get; set; }   
    }

    public class BadCarService //Programmierer B: 3 Tage 
    {
        public void RepairCar(BadCar car)
        {
            //Repariere Auto
        }
    }
    #endregion

    //Interfaces dauernt 1 Stunde 
    public interface ICar 
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }

    public interface ICarService 
    {
        void RepairCar(ICar car);
    }


    public class Car : ICar // 5 Tage
    {
        public int Id { get; set; } = 1;
        public string Model { get; set; } = "VW";
        public string Brand { get; set; } = "Polo";
    }

    public class CarService : ICarService // 3 Tage
    {
        public void RepairCar(ICar car)
        {
            //Auto wird repariert
        }
    }

    public class MockCar : ICar // 1 Tag 
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }

}
