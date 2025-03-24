namespace Classes
{   public class Room
    {
        public int Id { get; private set;}
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

    }
}
