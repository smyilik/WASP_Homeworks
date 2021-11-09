using System;
using System.Collections.Generic;

namespace _09_11_21_lesson
{
    public class Car
    {
        protected string label;
        protected int power;
        protected int year;
        public Car()
        {

        }
    }
    public class PassengerCar : Car
    {
        protected int amountOfPassengers;
        protected Dictionary<string, int> deteils = new Dictionary<string, int>();
        public PassengerCar() : base()
        {

        }
        public void AddDeteil(string name, int year)
        {
            deteils.Add(name, year);
        }
        public int GetYear(string name)
        {
            return (deteils[name]);
        }
        public void PrintDeteils()
        {
            foreach(KeyValuePair<string, int> h in deteils)
            {
                Console.WriteLine("Deteil " + h.Key + " Year " + h.Value);
            }
        }
        public string ConvertToStr()
        {
            return (label + " " + power + " " + year + " " + amountOfPassengers);
        }
    }
    public class Truck : Car
    {
        protected int maxmas;
        protected string drivername;
        protected Dictionary<string, int> mas = new Dictionary<string, int>();
        public Truck() : base()
        {

        }
        public void NewDriver(string name)
        {
            drivername = name;
        }
        public void AddMas(string name, int weight)
        {
            mas.Add(name, weight);
        }
        public void RemoveMas(string name, int weight)
        {
            mas.Remove(name, out weight);
        }
        public void PrintMas()
        {
            foreach(KeyValuePair<string, int> h in mas)
            {
                Console.WriteLine("Product name: " + h.Key + " Product weight: " + h.Value);
            }
        }
        public string ConvertToStr()
        {
            return (label + " " + power + " " + year + " " + maxmas + " " + drivername);
        }
        class Autopark
        {
            string name;
            List<PassengerCar> passengerCars = new List<PassengerCar>();
            List<Truck> trucks = new List<Truck>();
            Autopark(string name)
            {
                this.name = name;
            }
            public void PrintInfo()
            {
                string str = "";
                for (int i = 0; i < passengerCars.Count; i++)
                {
                    str += passengerCars[i].ConvertToStr();
                    str += " ";
                }
                for (int j = 0; j < trucks.Count; j++)
                {
                    if (j == trucks.Count)
                    {
                        str += trucks[j].ConvertToStr();
                    }
                    else
                    {
                        str += trucks[j].ConvertToStr();
                        str += " ";
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
