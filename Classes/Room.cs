namespace Classes
{
    public class Room
    {
        public int Id { get; private set; }
        private int MaxCapacity { get; set; }

        public bool IsReserved { get; set; }

        public Room(int id, int maxCapacity)
        {

            this.MaxCapacity = maxCapacity;
            this.Id = id;
            IsReserved = false;

            RoomManager.Instance.AddRoom(this);

        }
        //Every room gets the attribute IsReserved = false by default.

    
       
        public static Room CreateRoom(int id, int maxCapacity)
        {
            Room room = new Room(id, maxCapacity);
            Console.WriteLine("Sala criada com sucesso.");
            return room;
        }

        public Boolean ValidateMaxCapacity (Room room, int NumberOfParticipants )
        {
            if(room.MaxCapacity < NumberOfParticipants) {
                return false;
        }
            return true;
        }  

        public Boolean ValidateIfRoomIsAvailable (Room room) {
            return room.IsReserved;         
        }


          
            
}
}
