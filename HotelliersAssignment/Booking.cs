using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelliersAssignment
{
    public class Booking
    {
        public enum BookingType
        {
            Bedroom,
            ConferenceRoom
        }

        public string CustomerName { get; set; }
        public List<Room> ListRoom { get; set; }
        public Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public BookingType Type { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int Infants { get; set; }

        public Booking(string customerName, Room room, DateTime startDate, int duration, BookingType type, int adults, int children, int infants)
        {
            CustomerName = customerName;
            Room = room;
            StartDate = startDate;
            Duration = duration;
            Type = type;
            Adults = adults;
            Children = children;
            Infants = infants;
        }

        public Booking(string customerName, List<Room> rooms, DateTime startDate, int duration, BookingType type, int adults, int children, int infants)
        {
            CustomerName = customerName;
            ListRoom = rooms;
            StartDate = startDate;
            Duration = duration;
            Type = type;
            Adults = adults;
            Children = children;
            Infants = infants;
        }

        public void Book()
        {
            // Perform booking logic based on the provided scenario
            // For simplicity, this example just prints information
            Console.WriteLine($"Booking {Type} for {CustomerName}.");
            Console.WriteLine($"Room Number: {Room.RoomNumber}, Type: {Room.Type}, Start Date: {StartDate.ToShortDateString()}, Duration: {Duration} days.");

            if (Type == BookingType.ConferenceRoom)
            {
                Console.WriteLine($"Room Capacity: {Room.Capacity}, Presentation Equipment: {Room.PresentationEquipmentAvailable}");
            }

            // Add logic for checking availability, handling payments, etc.
        }

        public string ToStringMult()
        {
            string roomsInfo = string.Join(";", ListRoom.Select(room => room.RoomNumber)); // Assuming Room.ToString() provides necessary room information
            return $"{CustomerName},{roomsInfo},{StartDate},{Duration} days,{Type},{Adults},{Children},{Infants}\n";
        }
        public override string ToString()
        {
            return $"{CustomerName},{Room.RoomNumber},{StartDate},{Duration} days,{Type},{Adults},{Children},{Infants}\n";
        }
    }
}
