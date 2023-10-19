using Microsoft.Data.SqlClient;
using PRN_ASG.DAL;
using PRN_ASG2.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_ASG2.DAL
{
    internal class BookingDAO
    {
        private DAO dao;

        public BookingDAO()
        {
            dao = new DAO();
        }

        public List<Booking> FindAllBookings()
        {
            string query = "SELECT * FROM Bookings";
            DataTable result = dao.ExecuteQuery(query);
            List<Booking> bookings = new List<Booking>();

            foreach (DataRow row in result.Rows)
            {
                Booking booking = new Booking
                {
                    BookingID = (int)row["BookingID"],
                    ShowID = (int)row["ShowID"],
                    Name = row["Name"].ToString(),
                    SeatStatus = row["SeatStatus"].ToString(),
                    Amount = (decimal)row["Amount"]
                };

                bookings.Add(booking);
            }

            return bookings;
        }

        public Booking FindBookingById(int bookingID)
        {
            string query = "SELECT * FROM Bookings WHERE BookingID = @BookingID";
            SqlParameter parameter = new SqlParameter("@BookingID", bookingID);
            DataTable result = dao.ExecuteQuery(query, parameter);

            if (result.Rows.Count == 0)
                return null;

            DataRow row = result.Rows[0];
            Booking booking = new Booking
            {
                BookingID = (int)row["BookingID"],
                ShowID = (int)row["ShowID"],
                Name = row["Name"].ToString(),
                SeatStatus = row["SeatStatus"].ToString(),
                Amount = (decimal)row["Amount"]
            };

            return booking;
        }

        public List<Booking> FindBookingsByShowID(int showID)
        {
            string query = "SELECT * FROM Bookings WHERE ShowID = @ShowID";
            SqlParameter parameter = new SqlParameter("@ShowID", showID);
            DataTable result = dao.ExecuteQuery(query, parameter);
            List<Booking> bookings = new List<Booking>();

            foreach (DataRow row in result.Rows)
            {
                Booking booking = new Booking
                {
                    BookingID = (int)row["BookingID"],
                    ShowID = (int)row["ShowID"],
                    Name = row["Name"].ToString(),
                    SeatStatus = row["SeatStatus"].ToString(),
                    Amount = (decimal)row["Amount"]
                };

                bookings.Add(booking);
            }

            return bookings;
        }


        public bool DeleteBooking(int bookingID)
        {
            string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";
            SqlParameter parameter = new SqlParameter("@BookingID", bookingID);
            return dao.ExecuteNonQuery(query, parameter);
        }

        public bool UpdateBooking(Booking booking)
        {
            string query = "UPDATE Bookings SET ShowID = @ShowID, Name = @Name, SeatStatus = @SeatStatus, Amount = @Amount WHERE BookingID = @BookingID";

            SqlParameter[] parameters =
            {
            new SqlParameter("@ShowID", booking.ShowID),
            new SqlParameter("@Name", booking.Name),
            new SqlParameter("@SeatStatus", booking.SeatStatus),
            new SqlParameter("@Amount", booking.Amount),
            new SqlParameter("@BookingID", booking.BookingID)
        };

            return dao.ExecuteNonQuery(query, parameters);
        }

        public bool InsertBooking(Booking booking)
        {
            string query = "INSERT INTO Bookings (ShowID, Name, SeatStatus, Amount) VALUES (@ShowID, @Name, @SeatStatus, @Amount)";

            SqlParameter[] parameters =
            {
            new SqlParameter("@ShowID", booking.ShowID),
            new SqlParameter("@Name", booking.Name),
            new SqlParameter("@SeatStatus", booking.SeatStatus),
            new SqlParameter("@Amount", booking.Amount)
        };

            return dao.ExecuteNonQuery(query, parameters);
        }
    }

}
