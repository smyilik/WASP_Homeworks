using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace WASP_Lessons
{
    public class Metro
    {
        public List<Line> lines = new List<Line>();
        public string city;
        public Metro(string city)
        { 
            this.city = city;
        }
        public string GetCity()
        {
            return city;
        }
        public void AddLine(string name, string color)
        {
            this.lines.Add(new Line(name, color));
        }
        public void RemoveLine(string name)
        {
            int lineamount = lines.Count;
            for(int i = 0; i < lineamount; i++)
            {
                if (lines[i].name == name)
                {
                    lines.Remove(lines[i]);
                }
            }
        }
        public List<Station> FindStation(string name)
        {
            int lineamount = lines.Count, stationamount;
            foreach (Line line in lines)
            {
                foreach (Station station in GetStationList(line.GetName()))
                {
                    if (station.GetName() == name)
                    {
                        return GetStationList(line.GetName());
                    }
                }
            }
            return null;
        }
        public Station FindStation(string name, string lineName)
        {
            foreach (Line line in lines)
            {
                foreach (Station station in line.stations)
                {
                    if ((line.name == lineName) && (station.name == name))
                    {
                        return station;
                    }
                }
            }
            return null;
        }
        public List<Station> GetStationList(string name)
        {
            foreach (Line line in lines)
            {
                foreach (Station station in line.stations)
                {
                    if (station.name == name)
                    {
                        return line.stations;
                    }
                }
            }
            return null;
        }
        /*public void LoadStationsFromFile(string filename)
        {
            StreamReader r = new StreamReader("C:\\Users\\sanya\\OneDrive\\Рабочий стол\\" + filename);
            line.stations = r.ReadToEnd().Split('\n');
        }*/
    }
}
