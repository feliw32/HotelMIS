using System;
using HotelMIS.Model;

namespace HotelMIS.View
{
    public class AvailableRoomViewModel
    {
        public String _dateCheckIn;

        public String _dateCheckOut;

        public String _priceType;

        public String _room;

        public AvailableRoomViewModel(String prmRoom, String prmPriceType, String prmDateCheckIn, String prmDateCheckOut)
        {
            Room = prmRoom;
            PriceType = prmPriceType;
            DateCheckIn = prmDateCheckIn;
            DateCheckOut = prmDateCheckOut;
        }
        public AvailableRoomViewModel(String prmRoom)
        {
            Room = prmRoom;
            PriceType = "-";
            DateCheckIn = "-";
            DateCheckOut = "-";
        }

        public String DateCheckIn
        {
            get
            {
                return _dateCheckIn;
            }
            set
            {
                if (_dateCheckIn == value)
                    return;
                _dateCheckIn = value;
            }
        }

        public String DateCheckOut
        {
            get
            {
                return _dateCheckOut;
            }
            set
            {
                if (_dateCheckOut == value)
                    return;
                _dateCheckOut = value;
            }
        }

        public String PriceType
        {
            get
            {
                return _priceType;
            }
            set
            {
                if (_priceType == value)
                    return;
                _priceType = value;
            }
        }

        public String Room
        {
            get
            {
                return _room;
            }
            set
            {
                if (_room == value)
                    return;
                _room = value;
            }
        }
    }
}