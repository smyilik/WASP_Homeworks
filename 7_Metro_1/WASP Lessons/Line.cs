using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WASP_Lessons
{
    public class Line
    {
        public List<Station> stations = new List<Station>();
        public string name;
        public string color;
        public Line(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void AddStation(string name, string color)
        {
            stations.Add(new Station(name, color));
        }
        public void RemoveStation(string name)
        {
            stations.Remove(new Station(name, color));
        }
        public Station GetStation(string name)
        {
            foreach (Station station in stations)
            {
                if (station.GetName() == name)
                {
                    return station;
                }
            }
            return null;
        }
        public List<Station> GetStationList(string name)
        {
            return stations;
        }
    }
}
