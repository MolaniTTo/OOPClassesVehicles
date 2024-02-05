using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesEric
{
    public class MotorBike : Vehicles
    {
        private int cubicCentimeters;
        private bool sidecar;
        private bool isSidecar;

        public int CubicCentimeters { get { return cubicCentimeters; } set { cubicCentimeters = value; } }
        public bool Sidecar { get {  return sidecar; } set {  sidecar = value; } }
        public bool IsSidecar { get { return isSidecar; } set { if (Wheels == 3) { isSidecar = true; } } }
        public MotorBike(int cubicCentimeters, bool sidecar, string brand, string model, string licensePlate, int year, double kms, int wheels, bool isOlder, bool isSidecar) : base( brand, model, licensePlate, year, kms, wheels, isOlder)
        {
            CubicCentimeters = cubicCentimeters;
            Sidecar = sidecar;
            IsSidecar = isSidecar;
        }

        public void getMotorBikeInfo()
        {
            Console.WriteLine($"MotorBike Information:\n" +
                         $"Brand: {Brand}\n" +
                         $"Model: {Model}\n" +
                         $"License Plate: {LicensePlate}\n" +
                         $"Year: {Year}\n" +
                         $"Kilometers: {Kms}\n" +
                         $"Wheels: {Wheels}\n" +
                         $"CubicCentimeters: {CubicCentimeters}\n" +
                         $"IsOlder: {IsOlder}\n" +
                         $"IsSidecar: {IsSidecar}\n" +
                         $"Sidecar: {Sidecar}");
        }
    }
}
