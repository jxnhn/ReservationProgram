using Classes;
using UnitTests;

namespace IntegrationTests
{
    public class ReservationIntegrationTests 
    {
        
        [Fact]
        public void ShouldReserveMultipleRoomsIndependently()
        {
            // Arrange
            var room1 = Room.CreateRoom(1, 10);
            var room2 = Room.CreateRoom(2, 10);

            // Act
            var reservation1 = Reservation.CreateReservation(3, 1);
            var reservation2 = Reservation.CreateReservation(8, 2);

            // Assert
            Assert.NotNull(reservation1);
            Assert.NotNull(reservation2);
            Assert.True(room1.IsReserved);
            Assert.True(room2.IsReserved);
        }

        [Fact]
        public void ShouldOnlyReserveAvailableRooms_AndLeaveUnreservedRoomsIntact()
        {
            // Arrange
            var room1 = Room.CreateRoom(11, 3); // vai ser reservada
            var room2 = Room.CreateRoom(12, 2); // vai falhar na reserva

            // Act
            var successReservation = Reservation.CreateReservation(2, 11);
            var failedReservation = Reservation.CreateReservation(4, 12);

            // Assert
            Assert.NotNull(successReservation);
            Assert.Null(failedReservation);
            Assert.True(room1.IsReserved);
            Assert.False(room2.IsReserved);
        }

        [Fact]
        public void ShouldNotReserveAlreadyReservedRoomButAllowReservationOnAnotherRoom()
        {
            // Arrange
            var room1 = Room.CreateRoom(30, 4);
            var room2 = Room.CreateRoom(31, 4);

            // Act
            var firstReservation = Reservation.CreateReservation(4, 30);
            var secondReservationSameRoom = Reservation.CreateReservation(2, 30);
            var reservationOtherRoom = Reservation.CreateReservation(2, 31);

            // Assert
            Assert.NotNull(firstReservation);
            Assert.Null(secondReservationSameRoom);
            Assert.NotNull(reservationOtherRoom);
        }
    }
}
