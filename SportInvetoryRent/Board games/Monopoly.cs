using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInvetoryRent.Board_games
{
    class Monopoly:Boardgames
    {
        int maxplayer;
        int maxcubes;
        

        public Monopoly(string name, int price, string type, string gdirect,int maxplayer,int maxcubes):base (name,price,type,gdirect)
        {
            this.maxplayer = maxplayer;
            this.maxcubes = maxcubes;

        }
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Max. Player: ");sb.AppendLine(maxplayer.ToString());
            sb.Append("Max. cubes: ");sb.AppendLine(maxcubes.ToString());
            Console.WriteLine(sb);

        }
    }
}
