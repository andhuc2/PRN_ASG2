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
    internal class ShowDAO
    {

        private DAO dao;

        public ShowDAO()
        {
            dao = new DAO();
        }

        public List<Show> FindAllShows()
        {
            string query = "SELECT * FROM Shows";
            DataTable result = dao.ExecuteQuery(query);
            List<Show> shows = new List<Show>();

            foreach (DataRow row in result.Rows)
            {
                Show show = new Show();

                show.ShowID = (int)row["ShowID"];
                show.RoomID = (int)row["RoomID"];
                show.FilmID = (int)row["FilmID"];
                show.ShowDate = (DateTime)row["ShowDate"];
                show.Price = row["Price"] is DBNull ? null : (decimal?)row["Price"];
                show.Status = row["Status"] is DBNull ? null : (bool?)row["Status"];
                show.Slot = row["Slot"] is DBNull ? null : (int?)row["Slot"];

                shows.Add(show);
            }

            return shows;
        }

        public List<int> FindEmptySlot(DateTime date, int roomId)
        {
            string query = "SELECT Slot FROM Shows WHERE ShowDate = @date AND RoomID = @roomId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@roomId", roomId),
                new SqlParameter("@date", date.Date)
            };
            DataTable result = dao.ExecuteQuery(query, parameters);
            List<int> slots = Enumerable.Range(1, 9).ToList();

            if (result.Rows.Count == 0)
                return slots;

            foreach (DataRow row in result.Rows)
            {
                try
                {
                    int slot = (int)row["Slot"];
                    slots.Remove(slot);

                } catch (Exception ex) { }
            }

            return slots;
        }

        public Show FindShowById(int showId)
        {
            string query = "SELECT * FROM Shows WHERE ShowID = @ShowID";
            SqlParameter parameter = new SqlParameter("@ShowID", showId);
            DataTable result = dao.ExecuteQuery(query, parameter);

            if (result.Rows.Count == 0)
                return null;

            DataRow row = result.Rows[0];
            Show show = new Show();

            show.ShowID = (int)row["ShowID"];
            show.RoomID = (int)row["RoomID"];
            show.FilmID = (int)row["FilmID"];
            show.ShowDate = (DateTime)row["ShowDate"];
            show.Price = row["Price"] is DBNull ? null : (decimal?)row["Price"];
            show.Status = row["Status"] is DBNull ? null : (bool?)row["Status"];
            show.Slot = row["Slot"] is DBNull ? null : (int?)row["Slot"];

            return show;
        }

        public List<Show> FindShowsByCriteria(Show showData)
        {
            string query = "SELECT * FROM Shows WHERE RoomID = @RoomID AND ShowDate = @ShowDate AND FilmID = @FilmID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RoomID", showData.RoomID),
                new SqlParameter("@ShowDate", showData.ShowDate.Date),
                new SqlParameter("@FilmID", showData.FilmID)
            };

            DataTable result = dao.ExecuteQuery(query, parameters);
            List<Show> shows = new List<Show>();

            foreach (DataRow row in result.Rows)
            {
                Show show = new Show();

                show.ShowID = (int)row["ShowID"];
                show.RoomID = (int)row["RoomID"];
                show.FilmID = (int)row["FilmID"];
                show.ShowDate = (DateTime)row["ShowDate"];
                show.Price = row["Price"] is DBNull ? null : (decimal?)row["Price"];
                show.Status = row["Status"] is DBNull ? null : (bool?)row["Status"];
                show.Slot = row["Slot"] is DBNull ? null : (int?)row["Slot"];

                shows.Add(show);
            }

            return shows;
        }


        public bool DeleteShow(int showId)
        {
            string query = "DELETE FROM Shows WHERE ShowID = @ShowID";
            SqlParameter parameter = new SqlParameter("@ShowID", showId);
            return dao.ExecuteNonQuery(query, parameter);
        }

        public bool UpdateShow(Show show)
        {
            string query = "UPDATE Shows SET RoomID = @RoomID, FilmID = @FilmID, ShowDate = @ShowDate, " +
                           "Price = @Price, Status = @Status, Slot = @Slot WHERE ShowID = @ShowID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RoomID", show.RoomID),
                new SqlParameter("@FilmID", show.FilmID),
                new SqlParameter("@ShowDate", show.ShowDate),
                new SqlParameter("@Price", show.Price ?? (object)DBNull.Value),
                new SqlParameter("@Status", show.Status ?? (object)DBNull.Value),
                new SqlParameter("@Slot", show.Slot ?? (object)DBNull.Value),
                new SqlParameter("@ShowID", show.ShowID)
            };

            return dao.ExecuteNonQuery(query, parameters);
        }

        public bool InsertShow(Show show)
        {
            string query = "INSERT INTO Shows (RoomID, FilmID, ShowDate, Price, Status, Slot) " +
                           "VALUES (@RoomID, @FilmID, @ShowDate, @Price, @Status, @Slot)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RoomID", show.RoomID),
                new SqlParameter("@FilmID", show.FilmID),
                new SqlParameter("@ShowDate", show.ShowDate),
                new SqlParameter("@Price", show.Price ?? (object)DBNull.Value),
                new SqlParameter("@Status", show.Status ?? (object)DBNull.Value),
                new SqlParameter("@Slot", show.Slot ?? (object)DBNull.Value)
            };

            return dao.ExecuteNonQuery(query, parameters);
        }
    }

}
