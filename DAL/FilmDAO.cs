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
    internal class FilmDAO
    {
        private DAO dao;

        public FilmDAO()
        {
            dao = new DAO(); // You'll need to define your DAO class or data access mechanism.
        }

        public List<Film> FindAllFilms()
        {
            string query = "SELECT * FROM Films";
            DataTable result = dao.ExecuteQuery(query);
            List<Film> films = new List<Film>();

            foreach (DataRow row in result.Rows)
            {
                Film film = new Film();

                film.FilmID = (int)row["FilmID"];
                film.GenreID = (int)row["GenreID"];
                film.Title = row["Title"].ToString();
                film.Year = (int)row["Year"];
                film.CountryCode = row["CountryCode"].ToString();
                film.FilmUrl = row["FilmUrl"].ToString();

                films.Add(film);
            }

            return films;
        }

        public Film FindFilmById(int filmId)
        {
            string query = "SELECT * FROM Films WHERE FilmID = @FilmID";
            SqlParameter parameter = new SqlParameter("@FilmID", filmId);
            DataTable result = dao.ExecuteQuery(query, parameter);

            if (result.Rows.Count == 0)
                return null;

            DataRow row = result.Rows[0];
            Film film = new Film();

            film.FilmID = (int)row["FilmID"];
            film.GenreID = (int)row["GenreID"];
            film.Title = row["Title"].ToString();
            film.Year = (int)row["Year"];
            film.CountryCode = row["CountryCode"].ToString();
            film.FilmUrl = row["FilmUrl"].ToString();

            return film;
        }

        public bool DeleteFilm(int filmId)
        {
            string query = "DELETE FROM Films WHERE FilmID = @FilmID";
            SqlParameter parameter = new SqlParameter("@FilmID", filmId);
            return dao.ExecuteNonQuery(query, parameter);
        }

        public bool UpdateFilm(Film film)
        {
            string query = "UPDATE Films SET GenreID = @GenreID, Title = @Title, Year = @Year, " +
                           "CountryCode = @CountryCode, FilmUrl = @FilmUrl WHERE FilmID = @FilmID";

            SqlParameter[] parameters =
            {
            new SqlParameter("@GenreID", film.GenreID),
            new SqlParameter("@Title", film.Title),
            new SqlParameter("@Year", film.Year),
            new SqlParameter("@CountryCode", film.CountryCode),
            new SqlParameter("@FilmUrl", film.FilmUrl),
            new SqlParameter("@FilmID", film.FilmID)
        };

            return dao.ExecuteNonQuery(query, parameters);
        }

        public bool InsertFilm(Film film)
        {
            string query = "INSERT INTO Films (GenreID, Title, Year, CountryCode, FilmUrl) " +
                           "VALUES (@GenreID, @Title, @Year, @CountryCode, @FilmUrl)";

            SqlParameter[] parameters =
            {
            new SqlParameter("@GenreID", film.GenreID),
            new SqlParameter("@Title", film.Title),
            new SqlParameter("@Year", film.Year),
            new SqlParameter("@CountryCode", film.CountryCode),
            new SqlParameter("@FilmUrl", film.FilmUrl)
        };

            return dao.ExecuteNonQuery(query, parameters);
        }
    }
}
