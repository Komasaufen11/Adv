using Adventure.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class LookAroundCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            Console.WriteLine($"Rozhlédl jsi se a vidíš {world.CurrentRoom.Description}");
            if (world.CurrentRoom.Items.Count > 0)
            {
                Console.WriteLine("Něco se leskne ve tmě");
                Console.WriteLine(string.Join(",", world.CurrentRoom.Items.Select(i=>i.Name)));
            }
        }
    }
}
