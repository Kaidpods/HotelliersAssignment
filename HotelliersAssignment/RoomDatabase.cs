using HotelliersAssignment.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelliersAssignment
{
    public class RoomDatabase
    {
        private static RoomDatabase instance;
        private List<Room> rooms;

        private RoomDatabase()
        {
            // Initialize the list of rooms
            rooms = new List<Room>();
        }

        public static RoomDatabase Instance
        {
            get
            {
                // Lazy initialization of the singleton instance
                if (instance == null)
                {
                    instance = new RoomDatabase();
                }
                return instance;
            }
        }

        public void AddRoom(Room room)
        {
            // Add a room to the database
            rooms.Add(room);
        }

        public void ReadFileRooms()
        {
            // Reads from resource file
            string AllRooms = Resources.AllRooms;
            try
            {
                // Check if the resource content is not null or empty
                if (!string.IsNullOrEmpty(AllRooms))
                {
                    // Split the resource content by newline and read each line
                    string[] lines = AllRooms.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(',');
                        if (data.Length >= 5)
                        {
                            string roomNumber = data[0];
                            if (Enum.TryParse(data[1], out Room.RoomType roomType) &&
                                Enum.TryParse(data[2], out Room.Season roomSeason) &&
                                decimal.TryParse(data[3], out decimal rate) &&
                                int.TryParse(data[4], out int capacity))
                            {
                                Room room = new Room(roomNumber, roomType, roomSeason, rate, capacity);
                                AddRoom(room);
                            }
                            else
                            {
                                Console.WriteLine($"Error parsing line: {line}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid line format: {line}");
                        }
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading resource content: {ex.Message}");
            }
        }

        public List<Room> GetFreeRooms()
        {
            List<Room> roomList = new List<Room>();
            foreach (Room room in rooms)
            {
                if (room.IsOccupied != true)
                {
                    roomList.Add(room);
                }
                else
                {
                    Console.WriteLine(room.RoomNumber + " Is not free");
                }
            }
            return roomList;
        }

        public void UpdateRooms(string roomNum)
        {
            foreach (Room room in rooms)
            {
                if (room.RoomNumber == roomNum)
                {
                    room.IsOccupied = true;
                }
            }
        }

        public List<Room> GetRooms()
        {
            return rooms;
        }
    }
}
