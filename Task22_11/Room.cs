using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22_11
{
    internal class Room
    {
        private int _id = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity {  get; set; }
        public bool IsAvailable { get; set; } = true;
        public Room(string name, double price, int personCapacity, bool ısAvailable)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            IsAvailable = ısAvailable;
            _id++;
            Id = _id;
        }
        public string ShowInfo()
        {
            return $"Id:{Id},Name:{Name},Price:{Price},Person Capacity : {PersonCapacity},Room availability:{IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo() ;
        }
    }
}
