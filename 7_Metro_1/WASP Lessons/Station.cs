using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WASP_Lessons
{
    public class Station
    {
        public string name;
        public string color;
        public Line line;
        public bool isWheelchairAccessible;
        public bool hasParkAndRide;
        public bool hasNearbyCableCar;
        public List<Station> transfers;
        public Station(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Station(string name, string color, List<Station> transfers)
        {
            this.name = name;
            this.color = color;
            this.transfers = transfers;
        }
        public string GetName()
        {
            return (name);
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public bool IsWheelchairAccessible()
        {
            return isWheelchairAccessible;
        }
        public bool HasParkAndRide()
        {
            return hasParkAndRide;
        }
        public bool HasNearbyCableCar()
        {
            return hasNearbyCableCar;
        }
        public List<Station> GetTransferList()
        {
            return transfers;
        }
    }
}
