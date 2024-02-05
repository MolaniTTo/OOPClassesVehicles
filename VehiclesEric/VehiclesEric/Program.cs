using Pruebas;
using VehiclesEric;

namespace Program
{
    class Selector
    {
        public static void Main()
        {
            Car RayoMQ = new Car(4, "Red", "Rayo", "MQ", "ABC123", 2004, 10000.5, 4, false, false);
            RayoMQ.getCarInfo();
            Console.WriteLine();

            MotorBike LaBici = new MotorBike(1000, false, "XYZ", "ABC", "DEF456", 2021, 5000.75, 2, false, false);
            LaBici.getMotorBikeInfo();
            Console.WriteLine();

            Truck MateMQ = new Truck("Oxidado3000", 200000000000000000, "XYZ", "ABC", "DEF456", 2021, 5000.75, 2, false, false);
            MateMQ.getTruckInfo();

        }

    }
}