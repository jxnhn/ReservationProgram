using Classes;
using UnitTests;


namespace SystemTests
{
    public class SystemTests
    {

        private readonly RoomFixture _roomFixture;

        public SystemTests()
        {
            _roomFixture = new RoomFixture();

        }

        [Fact]
        //1 - Usuário cria uma sala
        public void CreateNewRoom()
        {
            var room = _roomFixture.CreateValidRoom();
            Assert.NotNull(room);
        }

        [Fact]
        //2 - Usuário cria uma reserva para sala que foi criada 

        public void CreateReservation()
        {
            var reservation = Reservation.CreateReservation(2, 1);
            Assert.NotNull(reservation);
            Assert.True(RoomManager.Instance.GetRoomById(1).IsReserved);
        }
    }
}