using HotelliersAssignment;
using System.Windows.Forms;

namespace HotelliersAssignment
{
    internal class Program
    {
        public static RoomDatabase roomDatabase = RoomDatabase.Instance;
        public static ClientDatabase clientDatabase = ClientDatabase.Instance;
        public static BookingDatabase bookingDatabase = BookingDatabase.Instance;

        
        static void Main(string[] args)
        {
            clientDatabase.createFile();
            roomDatabase.ReadFileRooms();
            Form MyForm = new Hoteliers();
            Application.Run(MyForm);
            
        }

    }
}