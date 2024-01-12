using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Client
    {
        private static int _clientNumber = 1;
        private int _id;
        private string _lastName;
        private string _firstName;
        private string _phoneNumber;
        private List<Reservation> _reservations;

        public int Id { get => _id; set => _id = value; }
        public List<Reservation> Reservations { get => _reservations; set => _reservations = value; }
        public string LastName { get => _lastName; }
        public string FirstName { get => _firstName; }

        public Client(string lastName, string firstName, string phoneNumber, Hotel hotel, int numberOfRoom)
        {
            _id = _clientNumber++;
            _lastName = lastName;
            _firstName = firstName;
            _phoneNumber = phoneNumber;
            _reservations = new List<Reservation>();
            hotel.Clients.Add(this);
            Reservation clientReservation = new(this, numberOfRoom, hotel);
            hotel.Reservations.Add(clientReservation);
            Reservations.Add(clientReservation);
        }

        public override string ToString()
        {
            return $"Client {_id} : {_lastName} {_firstName}";
        }

        public void ReadClientReservation(string clientFirstName, string clientLastName)
        {
            var myClientReservation = Reservations.Where(reservation => reservation.Client.FirstName == clientFirstName && reservation.Client.LastName == clientLastName);

            var myRoomId = Reservations.Where(reservation => reservation.ReservedRooms.)

            foreach (var reservation in myClientReservation)
            {
                Console.WriteLine($"Réservation n°{reservation} Monsieur/Madame {clientLastName} {clientFirstName} pour la chambre n°");
            }
        }
    }
}
