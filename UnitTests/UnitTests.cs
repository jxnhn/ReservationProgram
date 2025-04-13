using Classes;


namespace UnitTests
{
    public class UnitTests : IClassFixture<RoomFixture>
    {

        private readonly RoomFixture _roomFixture;

        public UnitTests(RoomFixture roomFixture) {
            _roomFixture = roomFixture; 
        }

        [Fact]
        public void IfRoomIsAlreadyReserved_ThenItCantBeReservedAgain()
        {
            var room = _roomFixture.CreateValidRoom();
            var firstreservation = Reservation.CreateReservation(4, 1);
            var secondreservation = Reservation.CreateReservation(3, 1);
            Assert.Null(secondreservation);
        }

        [Fact]
        public void IfNumberOfParticipantsExceedRoomMaxCapacity_ThenItShouldntBeReserved()
        {
            var room = _roomFixture.CreateValidRoom();
            var reservation = Reservation.CreateReservation(20, 1);
            Assert.Null(reservation);
        }

        [Fact]
        public void IfRoomDoesNotExist_ThenReservationShouldFail()
        {
            _roomFixture.CreateValidRoom();
            var reservation = Reservation.CreateReservation(3, 31);
            Assert.Null(reservation);
        }
    }

    public class RoomFixture
    {
        public RoomFixture()
        {
            //
        }

        public Room CreateValidRoom()
        {
            var room = Room.CreateRoom(1, 5);
            return room;
        }
    }

    
}