using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesEric
{
    public class Truck : Vehicles
    {
        private string type;
        private double tone;
        private bool isHeavy;

        public string Type { get { return type; } set { type = value; } }
        public double Tone { get { return tone; } set { tone = value; } }
        public bool IsHeavy { get { return isHeavy; } set { if (tone > 15) { isHeavy = true; } } }
        public Truck(string type, double tone, string brand, string model, string licensePlate, int year, double kms, int wheels, bool isOlder, bool isHeavy) : base(brand, model, licensePlate, year, kms, wheels, isOlder)
        {
            Type = type;
            Tone = tone;
            IsHeavy = isHeavy;
        }

        public void getTruckInfo()
        {
            Console.WriteLine($"Truck Information:\n" +
                         $"Brand: {Brand}\n" +
                         $"Model: {Model}\n" +
                         $"License Plate: {LicensePlate}\n" +
                         $"Year: {Year}\n" +
                         $"Kilometers: {Kms}\n" +
                         $"Wheels: {Wheels}\n" +
                         $"Type: {Type}\n" +
                         $"IsOlder: {IsOlder}\n" +
                         $"IsOlder: {IsHeavy}\n" +
                         $"Tone: {Tone}");
        }
    }
}
