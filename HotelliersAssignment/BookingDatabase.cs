using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static HotelliersAssignment.Booking;

namespace HotelliersAssignment
{
    public class BookingDatabase
    {
        private static BookingDatabase instance;
        private List<Booking> bookings;

        private BookingDatabase()
        {
            bookings = new List<Booking>();
        }

        public static BookingDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingDatabase();
                }
                return instance;
            }
        }

        public void AddBooking(Booking booking)
        {
            bookings.Add(booking);
            booking.Room.IsOccupied = true;
        }

        public void AddMultBooking(Booking booking)
        {
            foreach (Room room in booking.ListRoom)
            {
                room.IsOccupied = true;
            }
            bookings.Add(booking);
        }

        public void LoadBookingsFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    string customerName = parts[0];
                    List<Room> rooms = ParseRooms(parts[1]);
                    DateTime startDate = DateTime.Parse(parts[2]);
                    int duration = int.Parse(parts[3].Split(' ')[0]); // Assuming " days" suffix
                    BookingType type = (BookingType)Enum.Parse(typeof(BookingType), parts[4]);
                    int adults = int.Parse(parts[5]);
                    int children = int.Parse(parts[6]);
                    int infants = int.Parse(parts[7]);

                    Booking booking = new Booking(customerName, rooms, startDate, duration, type, adults, children, infants);
                    bookings.Add(booking);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading bookings from file: {ex.Message}");
            }
        }

        public void LoadBookingSingFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    string customerName = parts[0];
                    Room room = RoomParse(parts[1]);
                    DateTime startDate = DateTime.Parse(parts[2]);
                    int duration = int.Parse(parts[3].Split(' ')[0]); // Assuming " days" suffix
                    BookingType type = (BookingType)Enum.Parse(typeof(BookingType), parts[4]);
                    int adults = int.Parse(parts[5]);
                    int children = int.Parse(parts[6]);
                    int infants = int.Parse(parts[7]);

                    Booking booking = new Booking(customerName, room, startDate, duration, type, adults, children, infants);
                    bookings.Add(booking);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading bookings from file: {ex.Message}");
            }
        }

        private List<Room> ParseRooms(string roomsInfo)
        {
            List<Room> result = new List<Room>();
            string[] roomInfos = roomsInfo.Split(';');
            foreach (string roomInfo in roomInfos)
            {
                Program.roomDatabase.UpdateRooms(roomInfo);
                foreach (Room room in Program.roomDatabase.GetRooms())
                {
                    if (room.RoomNumber == roomInfo)
                    {
                        result.Add(room);
                    }
                }
            }
            return result;
        }

        private Room RoomParse(string v)
        {
            Room temp = null;
            foreach (Room room in Program.roomDatabase.GetRooms())
            {
                if (room.RoomNumber == v)
                {
                    temp = room;
                }
            }
            return temp;
        }

        public List<Booking> GetBookings()
        {
            return bookings;
        }

        public void removeBooking(Booking bookingToRemove)
        {
            bookings.Remove(bookingToRemove);
        }

        public void RemoveBookingFromFile(string filePath, string bookingToRemove)
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Find the index of the booking to remove
                int indexToRemove = Array.FindIndex(lines, line => line.Contains(bookingToRemove));

                if (indexToRemove != -1)
                {
                    // Remove the booking from the array
                    List<string> updatedLines = lines.ToList();
                    updatedLines.RemoveAt(indexToRemove);

                    // Write the updated lines back to the file
                    File.WriteAllLines(filePath, updatedLines);

                    Console.WriteLine("Booking removed from file successfully.");
                }
                else
                {
                    Console.WriteLine("Booking not found in file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing booking from file: {ex.Message}");
            }
        }
    }
}