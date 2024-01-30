namespace HotelliersAssignment
{
    public class Room
    {
        public enum RoomType
        {
            Single,
            Twin,
            Triple,
            Family,
            ConferenceRoom
        }

        public enum Season
        {
            High,
            Mid,
            Low
        }

        public string RoomNumber { get; set; }
        public RoomType Type { get; set; }
        public Season RoomSeason { get; set; }
        public decimal Rate { get; private set; }
        public int Capacity { get; private set; }
        public bool PresentationEquipmentAvailable { get; set; }
        public bool IsOccupied { get; set; }

        public Room(string roomNumber, RoomType type, Season season, decimal rate, int capacity)
        {
            RoomNumber = roomNumber;
            Type = type;
            RoomSeason = season;
            Rate = rate;
            Capacity = capacity;
            PresentationEquipmentAvailable = false;
            IsOccupied = false;
        }

        public decimal CalculateCost(int numberOfDays)
        {
            // Calculate the cost of booking based on the length of stay and room rate
            return numberOfDays * Rate;
        }
    }
}