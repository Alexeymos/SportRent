using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInvetoryRent.Street
{
    class Street_games:BaseInventory
    {
        string type;
        public string style;

        public Street_games(string name, int price, string type,string style):base (name,price)
        {
            type = "Game on Street";
            this.style = style;
        }
        public Street_games()
        {
            type = "Game on Street";
        }
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Style: ");sb.AppendLine(style);
            Console.Write(sb);
        }
        public override void AddInventry()
        {
            base.AddInventry();
            Console.Write("Enter game style: ");
            style = Console.ReadLine();

        }
    }
}
