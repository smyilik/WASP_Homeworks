using System;
using System.Collections.Generic;

namespace _09_11_21_lesson
{
    public class Car
    {
        protected string label;
        protected int power;
        protected int year;
        public Car(string label, int power, int year)
        {
            this.label = label;
            this.power = power;
            this.year = year;
        }
        public virtual string ToString()
        {
            return "";
        }
    }
    public class PassengerCar : Car
    {
        protected int amountOfPassengers;
        protected Dictionary<string, int> deteils;
        public PassengerCar(string label, int power, int year, int amountOfPassengers, Dictionary<string, int> deteils) : base(label, power, year)
        {
            this.amountOfPassengers = amountOfPassengers;
            this.deteils = deteils;
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
            foreach (KeyValuePair<string, int> h in deteils)
            {
                Console.WriteLine("Deteil " + h.Key + " Year " + h.Value);
            }
        }
        public override string ToString()
        {
            return label + " " + power + " " + year + " " + amountOfPassengers;
        }
    }
    public class Truck : Car
    {
        protected int maxmas;
        protected string drivername;
        protected Dictionary<string, int> mas;
        public Truck(string label, int power, int year, int maxmas, string drivername, Dictionary<string, int> mas) : base(label, power, year)
        {
            this.maxmas = maxmas;
            this.drivername = drivername;
            this.mas = mas;
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
            foreach (KeyValuePair<string, int> h in mas)
            {
                Console.WriteLine("Product name: " + h.Key + " Product weight: " + h.Value);
            }
        }
        public override string ToString()
        {
            return label + " " + power + " " + year + " " + maxmas + " " + drivername;
        }
    }
    class Autopark
    {
        protected string name;
        protected List<PassengerCar> passengerCars;
        protected List<Truck> trucks;
        public Autopark(string name, List<PassengerCar> passengerCars, List<Truck> trucks)
        {
            this.name = name;
            this.passengerCars = passengerCars;
            this.trucks = trucks;
        }
        public string PrintInfo()
        {
            string str = "";
            for (int i = 0; i < passengerCars.Count; i++)
            {
                str += passengerCars[i].ToString();
                str += " ";
            }
            for (int j = 0; j < trucks.Count; j++)
            {
                if (j == trucks.Count)
                {
                    str += trucks[j].ToString();
                }
                else
                {
                    str += trucks[j].ToString();
                    str += " ";
                }
            }
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("adfas", 1);
            dict.Add("bnbrf", 2);
            PassengerCar car = new PassengerCar("Porsche", 900, 2020, 2, dict);
            Console.WriteLine(car.ToString());
        }
    }
}
