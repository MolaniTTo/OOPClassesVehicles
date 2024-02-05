using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesEric
{
    public class Vehicles
    {
        private string brand;
        private string model;
        private string licensePlate;
        private int year;
        private double kms;
        private int wheels;
        private bool isOlder;

        public string Brand { get { return brand; } set {  brand = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double Kms { get {  return kms; } set {  kms = value; } }
        public int Wheels { get {  return wheels; } set {  wheels = value; } }
        public string LicensePlate { get {  return licensePlate; } set {  licensePlate = value; } }
        public bool IsOlder { get { return isOlder; } set { if (year < 2005) { isOlder = true; } } }
        public Vehicles (string brand, string model, string licensePlate, int year, double kms, int wheels, bool isOlder)
        {
            Brand = brand;
            Model = model;
            LicensePlate = licensePlate;
            Year = year;
            Kms = kms;
            Wheels = wheels;
            IsOlder = isOlder;
        }
    }
}
