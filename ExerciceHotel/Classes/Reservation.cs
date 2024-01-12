using ExerciceHotel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Reservation
    {
        private int _id;
        private ReservationStatus _status;
        private List<Room> _reservedRooms;
        private Client _client;

        public ReservationStatus Status { get => _status; set => _status = value; }
        public List<Room> ReservedRooms { get => _reservedRooms; set => _reservedRooms = value; }
        public Client Client { get => _client;}
        public int Id { get => _id;}

        public Reservation(Client client, int numberOfRooms, Hotel hotel)
        {
            _id = Hotel.NBOfReservations++;
            _client = client;
            _status = ReservationStatus.SCHEDULED;
            _reservedRooms = new();

            for (int i = 0; i < numberOfRooms; i++)
            {
                hotel.Rooms.Where(room => room.RoomStatus == RoomStatus.FREE).Take(numberOfRooms);
            }
            foreach (Room room in hotel.Rooms)
            {
                if (hotel.Rooms.Contains(room))
                    room.RoomStatus = RoomStatus.OCCUPIED;
            }


            for (int i = 0; i < numberOfRooms; i++)
            {
                ReservedRooms.Add(new Room());
            }

        }
    }
}
