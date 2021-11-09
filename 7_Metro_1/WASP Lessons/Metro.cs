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
        /*public List<Station> FindStation(string name)
        {
            int lineamount = lines.Count, stationamount;
            Line line;
            for (int i = 0; i < lineamount; i++)
            {
                line = lines[i];
                stationamount = line.stations.Count;
                for (int j = 0; j < stationamount; j++)
                {
                    if (line.stations[j].name == name)
                    {
                        return line.stations;
                    }
                }
            }
        }
        public Station FindStation(string name, string lineName)
        {
            int lineamount = lines.Count, stationsamount;
            Line line;
            for (int i = 0; i < lineamount; i++)
            {
                line = lines[i];
                stationsamount = line.stations.Count;
                for(int j = 0; j < stationsamount; j++)
                {
                    if ((line.name == lineName) && (line.stations[j].name == name))
                    {
                        return line.stations[j];
                    }
                }
            }
        }
        public List<Station> GetStationList(string name)
        {
            int lineamount = lines.Count, stationsamount;
            Line line;
            for (int i = 0; i < lineamount; i++)
            {
                line = lines[i];
                stationsamount = line.stations.Count;
                for(int j = 0; j < stationsamount; j++)
                {
                    if (line.stations[j].name == name)
                    {
                        return line.stations;
                    }
                }
            }
        }*/
        /*public void LoadStationsFromFile(string filename)
        {
            StreamReader r = new StreamReader("C:\\Users\\sanya\\OneDrive\\Рабочий стол\\" + filename);
            line.stations = r.ReadToEnd().Split('\n');
        }*/
    }
}
