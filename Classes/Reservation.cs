using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Reservation
    {
        internal int NumberOfParticipants { get; set; }
        public int RoomId {get; set;} 



        public static Reservation CreateReservation (int  NumberOfParticipants, int RoomId)
        {

            Boolean IsValid = Reservation.IsValid(NumberOfParticipants, RoomId);

            if (IsValid ) {
                Reservation reservation = new Reservation();
                reservation.RoomId = RoomId;
                reservation.NumberOfParticipants = NumberOfParticipants;
                return reservation;
            }

            Console.WriteLine("Não foi possível criar sua reserva.");
            return null;
        }

        public static Boolean IsValid (int NumberOfParticipants, int RoomId)
        {

            var Room = RoomManager.Instance.GetRoomById(RoomId);

            try { 
            if (!Room.ValidateMaxCapacity(Room, NumberOfParticipants))
            {
                Console.WriteLine("Reserva ultrapassa capacidade máxima da sala");
                     return false;
            }

            if (Room.ValidateIfRoomIsAvailable(Room))
            {
                Console.WriteLine("A sala já está reservada");
                     return false;
            }
            Room.IsReserved = true;
            return true;
            } 

            catch (Exception e) {
                return false;
            }

        }
    
            

           
}

}