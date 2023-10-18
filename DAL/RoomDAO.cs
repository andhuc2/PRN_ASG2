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
    internal class RoomDAO
    {
        private DAO dao;

        public RoomDAO()
        {
            dao = new DAO();
        }

        public List<Room> FindAllRooms()
        {
            string query = "SELECT * FROM Rooms";
            DataTable result = dao.ExecuteQuery(query);
            List<Room> rooms = new List<Room>();

            foreach (DataRow row in result.Rows)
            {
                Room room = new Room
                {
                    RoomId = (int)row["RoomID"],
                    Name = row["Name"].ToString(),
                    Rows = (int)row["NumberRows"],
                    Cols = (int)row["NumberCols"]
                };

                rooms.Add(room);
            }

            return rooms;
        }

        public Room FindRoomById(int roomId)
        {
            string query = "SELECT * FROM Rooms WHERE RoomID = @RoomId";
            SqlParameter parameter = new SqlParameter("@RoomId", roomId);
            DataTable result = dao.ExecuteQuery(query, parameter);

            if (result.Rows.Count == 0)
                return null;

            DataRow row = result.Rows[0];
            Room room = new Room
            {
                RoomId = (int)row["RoomID"],
                Name = row["Name"].ToString(),
                Rows = (int)row["NumberRows"],
                Cols = (int)row["NumberCols"]
            };

            return room;
        }

        public Room FindRoomByName(string name)
        {
            string query = "SELECT * FROM Rooms WHERE Name = @name";
            SqlParameter parameter = new SqlParameter("@name", name);
            DataTable result = dao.ExecuteQuery(query, parameter);

            if (result.Rows.Count == 0)
                return new Room();

            DataRow row = result.Rows[0];
            Room room = new Room
            {
                RoomId = (int)row["RoomID"],
                Name = row["Name"].ToString(),
                Rows = (int)row["NumberRows"],
                Cols = (int)row["NumberCols"]
            };

            return room;
        }

        public bool DeleteRoom(int roomId)
        {
            string query = "DELETE FROM Rooms WHERE RoomID = @RoomId";
            SqlParameter parameter = new SqlParameter("@RoomId", roomId);
            return dao.ExecuteNonQuery(query, parameter);
        }

        public bool UpdateRoom(Room room)
        {
            string query = "UPDATE Rooms SET Name = @Name, NumberRows = @Rows, NumberCols = @Cols WHERE RoomID = @RoomId";

            SqlParameter[] parameters =
            {
            new SqlParameter("@Name", room.Name),
            new SqlParameter("@Rows", room.Rows),
            new SqlParameter("@Cols", room.Cols),
            new SqlParameter("@RoomId", room.RoomId)
        };

            return dao.ExecuteNonQuery(query, parameters);
        }

        public bool InsertRoom(Room room)
        {
            string query = "INSERT INTO Rooms (Name, NumberRows, NumberCols) VALUES (@Name, @Rows, @Cols)";

            SqlParameter[] parameters =
            {
            new SqlParameter("@Name", room.Name),
            new SqlParameter("@Rows", room.Rows),
            new SqlParameter("@Cols", room.Cols)
        };

            return dao.ExecuteNonQuery(query, parameters);
        }
    }

}
