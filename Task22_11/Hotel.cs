using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22_11
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] _room= new Room[0];
        public int Index { get; set; }
        public Room this[int index]
        {
            get
            {
                return _room[index];
            }
            set
            {
                _room[index] = value;
            }
        }
        public Hotel(string name,int index)
        {
            Name=name;
            Index=index;
            Room[] room = new Room[0];
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _room, _room.Length + 1);
            _room[_room.Length - 1] = room;
        }
        public void Reserve(int? roomId)
        {
            if (roomId == null)
                throw new NotFoundException($"{Name} hotel does not have this room");

            int id = (int)roomId;

            
            if (id < 0 || id >= _room.Length)
                throw new NotFoundException($"{Name} hotel does not have this room");

            Room room = _room[id];

           
            if (room == null)
                throw new NotFoundException($"{Name} hotel does not have this room");

            
            if (!room.IsAvailable)
                throw new NotAvailableException("This room is not available");

            
            room.IsAvailable = false;
        }
    }
}
