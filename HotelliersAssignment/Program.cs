using System.Windows.Forms;

namespace HotelliersAssignment
{
    internal class Program
    {
        public static RoomDatabase roomDatabase = RoomDatabase.Instance;
        public static ClientDatabase clientDatabase = ClientDatabase.Instance;
        public static BookingDatabase bookingDatabase = BookingDatabase.Instance;
        private static string multPath = ("BookedMultRooms.txt");
        private static string singPath = ("BookedSingleRooms.txt");

        private static void Main(string[] args)
        {
            clientDatabase.createFile();
            roomDatabase.ReadFileRooms();
            bookingDatabase.LoadBookingsFromFile(multPath);
            bookingDatabase.LoadBookingSingFromFile(singPath);
            Form MyForm = new Hoteliers();
            Application.Run(MyForm);
        }
    }
}