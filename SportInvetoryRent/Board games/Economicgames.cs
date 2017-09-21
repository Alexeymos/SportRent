using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInvetoryRent.Board_games
{
    class Economicgames:Boardgames
    {
        int maxplayer;
        int maxcubes;
        

        public Economicgames(string name, int price, string type, string gdirect,int maxplayer,int maxcubes):base (name,price,type,gdirect)
        {
            this.maxplayer = maxplayer;
            this.maxcubes = maxcubes;

        }
        public Economicgames()
        {

        }
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Max. Player: ");sb.AppendLine(maxplayer.ToString());
            sb.Append("Max. cubes: ");sb.AppendLine(maxcubes.ToString());
            Console.WriteLine(sb);

        }
        public override void AddInventry()
        {
            string s;
            base.AddInventry();
            
            while (true)
            {

                Console.Write("Enter game maxplayer: ");
                try
                {
                    maxplayer = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException )
                {
                  
                    Console.WriteLine("Incorrect Input");
                }
            }
            while (true)
            {

                Console.Write("Enter game maxcubes: ");

                s = Console.ReadLine();
                if (int.TryParse(s, out maxcubes)) 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
        }
    }
}
