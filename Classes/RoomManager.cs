using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class RoomManager
    {
        //constructing a singleton list that will be responsable to manage the list of rooms createds in the current execution.

        private static RoomManager? _instance;
        private static readonly object _lock = new object();

        public List<Room> Rooms { get; private set; }

        private RoomManager()
        {

            Rooms = new List<Room>();

        }

        public static RoomManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RoomManager();
                }
                return _instance;
            }
        }

        public Room GetRoomById(int id)
        {
            var room = Rooms.FirstOrDefault(x => x.Id == id);
            if (room != null)
            {
                return room;
            }
            Console.WriteLine("Nenhuma sala encontrada com o ID informado");
            return null;
        }

        public void AddRoom(Room room)
        {

            var existingRooms = Rooms.FirstOrDefault(x => x.Id == room.Id);
            if (existingRooms == null)
            {
                Rooms.Add(room);

            }
            Console.WriteLine($"Sala com o Id {room.Id} já existe!");

        }
    }

}