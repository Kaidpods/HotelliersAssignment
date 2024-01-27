using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteliersAssignment
{
    public class Room
    {
        public enum RoomType
        {
            Single,
            Twin,
            Triple,
            Family
        }

        public enum Season
        {
            High,
            Mid,
            Low
        }

        public enum BookingType
        {
            Bedroom,
            ConferenceRoom
        }

        public string RoomNumber { get; set; }
        public RoomType Type { get; set; }
        public Season RoomSeason { get; set; }
        public decimal Rate { get; private set; }
        public int Capacity { get; private set; }
        public bool PresentationEquipmentAvailable { get; set; }

        public Room(string roomNumber, RoomType type, Season season, decimal rate, int capacity)
        {
            RoomNumber = roomNumber;
            Type = type;
            RoomSeason = season;
            Rate = rate;
            Capacity = capacity;
            PresentationEquipmentAvailable = false;
        }

        public decimal CalculateCost(int numberOfDays)
        {
            // Calculate the cost of booking based on the length of stay and room rate
            return numberOfDays * Rate;
        }

       
    }
}
