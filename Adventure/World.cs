using Adventure.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class World
    {
        public List<BaseRoom> rooms = new();
        public BaseRoom CurrentRoom { get; private set; }

        public World() 
        {
            var lobby = new Lobby();
            var corridor = new Corridor();

            lobby.RegisterNeighbour(corridor);


            rooms.AddRange(new BaseRoom[] { lobby, corridor });

            CurrentRoom = rooms[0];
        }

        public string Intro { get; } = $@"Procházíš se po noční Vlašimi a přepadla tě chuť na cígo, jdeš si přípálit, ale rozklepané ruce upustí zapalovač do kanálu. """"Kurva"""" Použiješ opileckou sílu k zvednutí poklopu a bezmeš si ho s sebou do hlubin. 
";
    }
}
