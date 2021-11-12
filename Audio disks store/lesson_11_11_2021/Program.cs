using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public interface IStoreItem
    {
        public double Price { get; set; }
        public void DiscountPrice(int percent);
    }
    public class Disk : IStoreItem
    {
        protected string name, genre;
        protected int burnCount;
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }
        public virtual int DiskSize
        {
            get {return 0; }
        }

        public double Price { get; set; }

        public virtual void Burn (params string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        name = values[i];
                        break;
                    case 1:
                        genre = values[i];
                        break;
                }
            }
            burnCount++;
        }

        public void DiscountPrice(int percent)
        {
            Price *= Convert.ToDouble(100 - percent) / 100.0;
        }

        public virtual string ToString()
        {
            return name + " " + genre + " " + burnCount;
        }
    }
    public class Audio : Disk
    {
        protected string artist, recordingStudio;
        protected int songsNumber;
        public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
        }
        public string Name
        {
            get { return name; }
        }
        public override int DiskSize
        {
            get { return songsNumber * 8; }
        }
        public override void Burn(params string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        name = values[i];
                        break;
                    case 1:
                        genre = values[i];
                        break;
                    case 2:
                        artist = values[i];
                        break;
                    case 3:
                        recordingStudio = values[i];
                        break;
                    case 4:
                        int.TryParse(values[i], out songsNumber);
                        break;
                }
            }
            burnCount++;
        }
        public override string ToString()
        {
            return name + " " + genre + " " + artist + " " + recordingStudio + " " + songsNumber + " " + burnCount;
        }
    }
    class DVD : Disk
    {
        protected string producer, filmCompany;
        protected int minutesCount;
        public DVD(string producer, string filmCompany, int minutesCount, string name, string genre) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
        }
        public string Name
        {
            get { return name; }
        }
        public override int DiskSize
        {
            get { return (minutesCount / 64) * 2; }
        }
        public override void Burn(params string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        name = values[i];
                        break;
                    case 1:
                        genre = values[i];
                        break;
                    case 2:
                        producer = values[i];
                        break;
                    case 3:
                        filmCompany = values[i];
                        break;
                    case 4:
                        int.TryParse(values[i], out minutesCount);
                        break;
                }
            }
            burnCount++;
        }
        public override string ToString()
        {
            return name + " " + genre + " " + producer + " " + filmCompany + " " + minutesCount + " " + burnCount;
        }
    }
    public class Store
    {
        private string storeName, address;
        private List<Audio> audios = new List<Audio>();
        private List<DVD> dvds = new List<DVD>();
        public Store(string storeName, string address)
        {
            this.storeName = storeName;
            this.address = address;
        }
        public List<Audio> GetAudios
        {
            get { return audios; }
            set { audios = value; }
        }
        /*public List<DVD> GetDVDs
        {
            get { return dvds; }
            set { dvds = value; }
        }*/
        public virtual string ToString()
        {
            string str = "";
            foreach (Audio a in audios)
            {
                str += a.ToString() + '\n';
            }
            foreach (DVD d in dvds)
            {
                str += d.ToString() + '\n';
            }
            return (str.Trim('\n'));
        }
        public static Store operator +(Store store, Audio value)
        {
            store.audios.Add(value);
            return store;
        }
        public static Store operator -(Store store, Audio value)
        {
            store.audios.Remove(value);
            return store;
        }
        /*public static Store operator +(Store store, DVD value)
        {
            store.dvds.Add(value);
            return store;
        }
        public static Store operator -(Store store, DVD value)
        {
            store.dvds.Remove(value);
            return store;
        }*/
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Store store = new Store("DNS", "Shopping Centre Columbus");
            store += new Audio("Morgenshtern", "Moscow", 65, "Dulo", "Rap");
            store += new Audio("Morgenshtern", "Moscow", 65, "Cadillac", "Rap");
            store += new Audio("Morgenshtern", "Moscow", 65, "Clown", "Rap");
            /*store += new DVD("Christopher Columbus", "Warner Brothers", 120, "Harry Potter and the Philosophers Stone", "Adventure");
            store += new DVD("Christopher Columbus", "Warner Brothers", 120, "Harry Potter and the Chamber of Secrets", "Adventure");
            store += new DVD("Christopher Columbus", "Warner Brothers", 120, "Harry Potter and the Prisoner of Azkaban", "Adventure");*/
            store.GetAudios[0].Burn(new string[] { "Nominallo", "Rap", "Morgenshtern", "Moscow", "65" });
            Console.WriteLine(store.ToString());
            foreach (Audio a in store.GetAudios)
            {
                Console.WriteLine(a.Name + a.DiskSize);
            }
            /*foreach (DVD d in store.GetDVDs)
            {
                Console.WriteLine(d.Name + d.DiskSize);
            }*/
        }
    }
}