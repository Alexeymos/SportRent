﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInvetoryRent.Street
{
    class Tenis:Street_games
    {
        public string racketmade;
        public string ballmade;

        public Tenis(string name, int price, string type, string style,string racketmade,string ballmade):base (name,price,type,style)
        {
            this.racketmade = racketmade;
            this.ballmade = ballmade;
        }
        public Tenis()
        {

        }
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Raket Made in: ");sb.AppendLine(racketmade);
            sb.Append("Ball Made in: ");sb.AppendLine(ballmade);
            Console.WriteLine(sb);
        }
        public override void AddInventry()
        {
            base.AddInventry();
            Console.Write("Enter racketmade: ");
            racketmade = Console.ReadLine();
            Console.Write("Enter ballmade: ");
            ballmade = Console.ReadLine();
        }
    }
}
