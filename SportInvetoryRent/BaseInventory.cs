using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInvetoryRent
{
    class BaseInventory
    {
        public string name;
        public int price;
        public BaseInventory(string name, int price)
        {
            this.name = name;
            this.price = price;          
        }
        public BaseInventory()
        {

        }
        public virtual void Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: "); sb.AppendLine(name);
            sb.Append("Price: "); sb.AppendLine(price.ToString());
           // sb.Append("Game type: "); sb.AppendLine(type);
            Console.Write(sb);
        }
        public virtual void AddInventry()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            while (true)
            {

                Console.Write("Enter price: ");
                try
                {
                    price = int.Parse(Console.ReadLine()); 
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect Input");
                }

            }
        }

    }
}
