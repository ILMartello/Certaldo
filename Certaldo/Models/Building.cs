using System;
using System.Collections.Generic;

namespace Certaldo.Models
{
    public class Building
    {
        public string Name { get; set; }
        public List<Floor> Floors { get; set; }
    }

    public class Floor
    {
        public int index;
        public string Name { get; set; }
        public List<Room_> Rooms { get; set; }
    }

    public class Room_
    {
        public int index { get; set; }
        public string Name { get; set; }
    }
}
