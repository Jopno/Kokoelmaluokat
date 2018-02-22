using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace SmLiiga
{
    [Serializable]
    class Team
    {
        private string Name { get; set; }
        private string City { get; set; }
        public List<Player> players = new List<Player>();

        public Team(string name, string city)
        {
            Name = name;
            City = city;
            players = ReadFromFile();
        }

        public List<Player> GetPlayers()
        {
            players.Add(new Player("Juho", "Olkinuora", 45, "L"));
            players.Add(new Player("Nolan", "Yonkman", 43, "R"));
            players.Add(new Player("JP", "Hytonen", 15, "L"));
            players.Add(new Player("Ossi" ,"Louhivaara", 23, "R"));
            return players;
        }

        public void SaveToFile()
        {
            Stream writeMultipleStream = new FileStream("Players", FileMode.Create, FileAccess.Write, FileShare.None);

            IFormatter formatter = new BinaryFormatter();

            formatter.Serialize(writeMultipleStream, players);

            writeMultipleStream.Close();
        }

        public List<Player> ReadFromFile()
        {
            Stream openStream = new FileStream("Players.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            IFormatter formatter = new BinaryFormatter();

            List<Player> readPlayers = (List<Player>)formatter.Deserialize(openStream);

            openStream.Close();

            return readPlayers;
        }

        public void ShowPlayers()
        {
            foreach (Player player in players)
            {
                Console.WriteLine(player.ToString());
            }
        }

        public override string ToString()
        {
            return "Company name: " + Name + " Hometown: " + City;
        }
    }
}
