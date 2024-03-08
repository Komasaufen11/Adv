using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class HelpCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            Console.WriteLine("Příkazy pro blbečky ...");
            Console.WriteLine("---");
            Console.WriteLine("Rozhlídnout - co myslíš");

            Console.WriteLine();
            Console.WriteLine("help - hňupe");
            Console.WriteLine("quit - srabe");
        }
    }
}
