using ExerciceHotel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Room
    {
        private static int _numberOfRooms;
        private int _roomId;
        private RoomStatus _roomStatus;
        private int _bedNb;
        private decimal _price;
        internal RoomStatus RoomStatus { get => _roomStatus; set => _roomStatus = value; }
        public int RoomId { get => _roomId; }

        public Room()
        {
            _roomId = _numberOfRooms++;
            RoomStatus = RoomStatus.FREE;
            _bedNb = 2;
            _price = 100;
        }

        public override string ToString()
        {
            return $" pour la chambre n° {RoomId.ToString()}";
        }

    }
}
