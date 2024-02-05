using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesEric;

namespace Pruebas
{
    public class Car : Vehicles
    {
        private int door;
        private string color;
        private bool isBig;

        public int Door {  get { return door; } set {  door = value; } }
        public string Color { get { return color; } set { color = value; } }
        public bool IsBig { get { return isBig; } set { if ((2024 - Year) > 15) { isBig = true; } } }

        public Car (int door, string color, string brand, string model, string licensePlate, int year, double kms, int wheels, bool isOlder, bool isBig) : base (brand, model, licensePlate, year, kms, wheels, isOlder)
        {
            Door = door;
            Color = color;
            IsBig = isBig;
        }

        public void getCarInfo()
        {
            Console.WriteLine($"Car Information:\n" +
                         $"Brand: {Brand}\n" +
                         $"Model: {Model}\n" +
                         $"License Plate: {LicensePlate}\n" +
                         $"Year: {Year}\n" +
                         $"Kilometers: {Kms}\n" +
                         $"Wheels: {Wheels}\n" +
                         $"Doors: {Door}\n" +
                         $"IsOlder: {IsOlder}\n" +
                         $"IsBig: {IsBig}\n" +
                         $"Color: {Color}\n");
                         
        }
    }

}
