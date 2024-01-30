using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelliersAssignment.UnitTest
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void GetStaffCredentials_DecryptAndStoreCredentials_Success()
        {
            // Arrange
            var hoteliersForm = new Hoteliers();

            // Act
            hoteliersForm.GetStaffCredentials();

            // Assert
            Assert.IsNotNull(hoteliersForm.staffUser);
            Assert.IsNotNull(hoteliersForm.staffPass);
        }

        [TestMethod]
        public void ListBoxGeneration_PopulateListBoxWithBookings_Success()
        {
            // Arrange
            var hoteliersForm = new Hoteliers();
            // Assuming Program.bookingDatabase.GetBookings() returns a list of bookings for testing
            BookingDatabase bookingDb = BookingDatabase.Instance; // Initialize the booking database with test data

            // Act
            hoteliersForm.ListBoxGeneration();

            // Assert
            Assert.AreEqual(Program.bookingDatabase.GetBookings().Count, hoteliersForm.listBox1.Items.Count);
            // Add more specific assertions based on the expected booking details
        }
    }
}