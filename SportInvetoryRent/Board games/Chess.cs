﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInvetoryRent.Board_games
{
    class Chess:Boardgames
    {
        public string boardmat;
        public string figuremat;

        public Chess(string name, int price, string type, string gdirect,string boardmat,string figuremat):base (name,price,type,gdirect)
        {
            this.boardmat = boardmat;
            this.figuremat = figuremat;
        }
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Board: ");sb.AppendLine(boardmat);
            sb.Append("Figure: ");sb.AppendLine(figuremat);
            Console.WriteLine(sb);
        }
    }
}
