using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInvetoryRent.Street
{
    class Bowls:Street_games
    {
        public int ballsize;
        public string bowlmat;

        public Bowls(string name, int price, string type, string style,int ballsize,string bowlmat):base (name,price,type,style)
        {
            this.ballsize = ballsize;
            this.bowlmat = bowlmat;
        }
        public Bowls()
        {

        }
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Size ball: ");sb.AppendLine(ballsize.ToString());
            sb.Append("Bowl: ");sb.AppendLine(bowlmat);
            Console.WriteLine(sb);
        }
        public override void AddInventry()
        {
            base.AddInventry();
            while (true)
            {

                Console.Write("Enter ballsize: ");
                try
                {
                    ballsize = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException )
                {
                   
                    Console.WriteLine("Incorrect Input");
                }
            }
            
            
            Console.Write("Enter bowlmat: ");
            bowlmat = Console.ReadLine();
        }
    }
}
