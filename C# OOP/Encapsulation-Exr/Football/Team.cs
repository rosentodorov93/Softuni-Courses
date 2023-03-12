using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Team
    {
        private string name;
        private List<Player> players;
        private decimal rating;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => name; 
            private set
            {
                if (value == " " || value == string.Empty || value == null)
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public decimal Rating => GetRating();

        public IReadOnlyCollection<Player> Players { get => this.players.AsReadOnly(); }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }
        public decimal GetRating()
        {
            var result = 0m;
            foreach (var player in Players)
            {
                decimal value = (player.Dribble + player.Shooting + player.Passing + player.Sprint + player.Endurance) / 5m;
                result += Math.Round(value,0);
            }
            return result;
        }
    }
}
