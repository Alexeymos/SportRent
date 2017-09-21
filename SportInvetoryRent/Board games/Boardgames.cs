using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInvetoryRent.Board_games
{
    class Boardgames:BaseInventory
    {
        string type;
        public string gdirect;

        public Boardgames(string name, int price,string type, string gdirect):base (name,price)
        {
            type = "Game on Board";
            this.gdirect = gdirect;
        }
        public Boardgames()
        {
            type = "Game on Board";
        }
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Game direct: ");sb.AppendLine(gdirect);
            sb.Append("Game type: "); sb.AppendLine(type);
            Console.Write(sb);
        }
        public override  void AddInventry()
        {
            base.AddInventry();
            Console.Write("Enter game dirrect: ");
             gdirect = Console.ReadLine();
          
        }
    }
}
