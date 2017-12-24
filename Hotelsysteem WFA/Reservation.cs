using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelsysteem_WFA
{
    class Reservation
    {

        public Reservation(int _id, DateTime _beginDateTime, DateTime _endDateTime, int _room, string _address, string _residence, string _name1)
        {
            id = _id;
            beginDateTime = _beginDateTime;
            endDateTime = _endDateTime;
            room = _room;
            address = _address;
            residence = _residence;
            name1 = _name1;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime beginDateTime;

        public DateTime BeginDateTime
        {
            get { return beginDateTime; }
            set { beginDateTime = value; }
        }

        private DateTime endDateTime;

        public DateTime EndDateTime
        {
            get { return endDateTime; }
            set { endDateTime = value; }
        }

        private int room;

        public int Room
        {
            get { return room; }
            set { room = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string residence;

        public string Residence
        {
            get { return residence; }
            set { residence = value; }
        }


        private string name1;

        public string Name1
        {
            get { return name1; }
            set { name1 = value; }
        }

        private string name2;

        public string Name2
        {
            get { return name2; }
            set { name2 = value; }
        }

        private string name3;

        public string Name3
        {
            get { return name3; }
            set { name3 = value; }
        }

        private string name4;

        public string Name4
        {
            get { return name4; }
            set { name4 = value; }
        }

        public override string ToString()
        {
            return $"ID:{id};B:{beginDateTime.ToLongDateString()};E:{endDateTime.ToLongDateString()};R:{room};A:{address};RE:{residence};P1:{name1};";
        }
    }
}
