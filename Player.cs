using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_APP
{
    class Player : Team
    {
        int id;
        string name;
        int age;
        string battingStyle;
        string bowligstyle;

        public Player()
        {
        }

        public Player(int id, string name, int age, string battingStyle, string bowligstyle)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.battingStyle = battingStyle;
            this.bowligstyle = bowligstyle;
        }
        public Player(string teamName, string country, int id, string name, int age, string battingStyle, string bowligstyle)
            : base(teamName, country)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.battingStyle = battingStyle;
            this.bowligstyle = bowligstyle;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string BattingStyle { get => battingStyle; set => battingStyle = value; }
        public string Bowligstyle { get => bowligstyle; set => bowligstyle = value; }

        public override bool Equals(object obj)
        {
            Player obj_playe = (Player)obj;
            return this.Name.Equals(obj_playe.Name) && this.TeamName.Equals(obj_playe.TeamName);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
