using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WASP_Lessons
{
    public class Line
    {
        public List<Station> stations;
        public string name;
        public string color;
        public Line(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Station GetStation(string name)
        {
            return new Station(name, color);
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
        public Station FindStationByName(string name)
        {
            int len = stations.Count;
            for(int i = 0; i < len; i++)
            {
                if (stations[i].name == name)
                {
                    return stations[i];
                }
            }
        }
        public List<Station> GetStationList(string name)
        {
            return stations;
        }
    }
}
