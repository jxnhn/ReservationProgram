using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using UnitTests;
using Xunit;
using SpecFlow;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using Newtonsoft.Json.Bson;

namespace ReservationAcceptance.Steps
{
    [Binding]
    public class ReservationSteps
    {
        private readonly RoomFixture _roomFixture;
        private Reservation _firstReservation;
        private Reservation _secondReservation;
        private Reservation _invalidReservation;
        private Reservation _inexistentReservation;

        public ReservationSteps(RoomFixture roomFixture)
        {
            _roomFixture = roomFixture;
        }

        [Given(@"existe uma sala com ID (.*) e capacidade máxima de (.*) pessoas")]
        public void GivenExisteUmaSalaComCapacidade(int roomId, int capacity)
        {
     
            _roomFixture.CreateValidRoom(); 
        }

        [When(@"faço uma reserva para (.*) pessoas na sala (.*)")]
        public void WhenFacoUmaReserva(int participants, int roomId)
        {
            _firstReservation = Reservation.CreateReservation(participants, roomId);
        }

        [When(@"tento fazer uma reserva inválida para (.*) pessoas na sala (.*)")]

        public void WhenFacoUmaReservaInvalida(int participants, int roomId)
        {
            _invalidReservation = Reservation.CreateReservation(participants, roomId);
        }

        [When(@"tento fazer outra reserva para (.*) pessoas na mesma sala (.*)")]
        public void WhenTentoFazerOutraReserva(int participants, int roomId)
        {
            _secondReservation = Reservation.CreateReservation(participants, roomId);
        }

        [When(@"tento fazer uma reserva para uma sala inexistente para (.*) pessoas na sala (.*)")]

        public void WhenTentoReservarSalaInexistente(int participants, int roomId)
        {
            _inexistentReservation = Reservation.CreateReservation(participants, roomId);
        }


        [Then(@"a reserva não deve ser criada")]
        public void ThenAReservaNaoDeveSerCriada()
        {
            Assert.Null(_invalidReservation);
        }

        [Then(@"a reserva não pode ser criada")]
        public void ThenAReservaNaoPodeSerCriada()
        {
            Assert.Null(_inexistentReservation);
        }

        [Then(@"a segunda reserva não deve ser criada")]
        public void ThenASegundaReservaNaoDeveSerCriada()
        {
            Assert.Null(_secondReservation);
        }

        [Then(@"o sistema deve retornar null para a segunda reserva")]
        public void ThenOSistemaDeveRetornarNullParaASegundaReserva()
        {
            Assert.Null(_secondReservation);
        }
    }

}
