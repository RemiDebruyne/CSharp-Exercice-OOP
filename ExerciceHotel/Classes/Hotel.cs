using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Hotel
    {
        private static int _nBOfReservations;
        private string _nom;
        private List<Client> _clients;
        private List<Reservation> ?_reservations;
        private List<Room> _rooms;
        public List<Client> Clients { get => _clients; set => _clients = value; }
        public List<Reservation> Reservations { get => _reservations; set => _reservations = value; }
        internal List<Room> Rooms { get => _rooms; set => _rooms = value; }
        public static int NBOfReservations { get => _nBOfReservations; set => _nBOfReservations = value; }

        public Hotel(string nom, int nBOfRoom)
        {
            _nom = nom;
            _reservations = new();
            _clients = new();
            _rooms = new();
            while(_rooms.Count < 20)
            {
                new Room();
            }
        }

        public void ReadClientList()
        {
            foreach (var client in Clients) {

                Console.WriteLine(client);
            }
        }

        public void AddClient(string lastName, string firstName, string phoneNumber, Hotel hotel, int nBOfRooms)
        {
            new Client(lastName, firstName, phoneNumber, hotel, nBOfRooms);
            // Creating a new client also creates his reservation
        }
    }

}
