using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrack
{
    class ParkingCollection
    {

        readonly Dictionary<string, Parking<Vehicle>> parkingStages;

        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }

                return null;

            }
        }
       
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"ParkingCollection");
                foreach (var level in parkingStages)
                {
                    sw.WriteLine($"Parking{separator}{level.Key}");
                    foreach (ITransport track in level.Value)
                    {

                        if (track.GetType().Name == "Track")
                        {
                            sw.Write($"Track{separator}");
                        }
                        if (track.GetType().Name == "Benzovoz")
                        {
                            sw.Write($"Benzovoz{separator}");
                        }
                        sw.WriteLine(track);

                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();

            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                string key = string.Empty;
                Vehicle track = null;
                if (line.Contains("ParkingCollection"))
                {
                    parkingStages.Clear();
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains("Parking"))
                        {
                            key = line.Split(separator)[1];
                            parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                            line = sr.ReadLine();
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            line = sr.ReadLine();
                            continue;
                        }
                        if (line.Split(separator)[0] == "Track")
                        {
                            track = new Track(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Benzovoz")
                        {
                            track = new Benzovoz(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + track;
                        if (!result)
                        {
                            throw new ArgumentNullException("Не удалось загрузить автомобиль на парковку");
                        }
                        line = sr.ReadLine();
                    }
                    return true;
                }
                throw new FormatException("Неверный формат файла");
            }
        }
    }
}




