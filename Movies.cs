using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//Saved
namespace CSI3450_MovieDatabase
{
    public class Movies
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "csi3450_phase2";
        private const String UID = "root";
        private const String PASSWORD = "Ac1506568";
        public static MySqlConnection dbConn;

        public int id_Movie { get; private set; }
        public String title_Movie { get; private set; }
        public String description_Movie { get; private set; }
        public String releaseDate_Movie { get; private set; }
        public int length_Movie { get; private set; }
        public int Director_id_Movie { get; private set; }
        public String director_lname { get; private set; }
        public String director_fname { get; private set; }
        public int director_age { get; private set; }

        private Movies(int id, string title, string description, string releaseDate, int length, int directorID)
        {
            id_Movie = id;
            title_Movie = title;
            description_Movie = description;
            releaseDate_Movie = releaseDate;
            length_Movie = length;
            Director_id_Movie = directorID;
        }
        private Movies(string title, string description, string releaseDate, int length, int dirid, String fname, String lname, int age)
        {
            Director_id_Movie = dirid;
            director_fname = fname;
            director_lname = lname;
            director_age = age;
            title_Movie = title;
            description_Movie = description;
            releaseDate_Movie = releaseDate;
            length_Movie = length;
        }
        public static void initializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            String connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);
        }
        public static List<Movies> GetMovies()
        {
            List<Movies> movies = new List<Movies>();

            String query = "Select * from movie";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            
            while (reader.Read())
            {
                int id = (int)reader["id_movie"];
                string title = reader["title_movie"].ToString();
                string description = reader["description_movie"].ToString();
                string release = reader["releaseDate_movie"].ToString();
                int length = (int)reader["length_movie"];
                int directorNumber = (int)reader["director_id_director"];

                Movies m = new Movies(id, title, description, release, length, directorNumber);

                movies.Add(m);
            }

            dbConn.Close();
            return movies;
        }

        public static List<Movies> GetSearch()
        {
            
            List<Movies> movies = new List<Movies>();
            var inputSearch = Form1.searchInput;
            String query = string.Format("Select * From movie where title_movie like '%" + inputSearch +"%'");
            MySqlCommand cmd = new MySqlCommand(query,dbConn);


            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                int id = (int)reader["id_movie"];
                string title = reader["title_movie"].ToString();
                string description = reader["description_movie"].ToString();
                string release = reader["releaseDate_movie"].ToString();
                int length = (int)reader["length_movie"];
                int directorNumber = (int)reader["director_id_director"];

                Movies m = new Movies(id, title, description, release, length, directorNumber);

                movies.Add(m);
            }

            dbConn.Close();
            return movies;
        }
        public static void AddMovies()
        {
            var newMovieID = Form1.addMovieId;
            var newTitle = Form1.addTitle;
            var newDesc = Form1.addDesc;
            var newRelease = Form1.date;
            var newLength = Form1.addLength;
            var newDirectorID = Form1.addDirectorID;
            
            String query = string.Format("Insert into movie (id_movie, title_movie,description_movie, releaseDate_movie, length_movie, Director_id_Director)" +
                "values ({0},'{1}','{2}','{3}',{4},{5})", newMovieID, newTitle, newDesc, newRelease, newLength, newDirectorID);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);


            dbConn.Open();

            cmd.ExecuteNonQuery();

            dbConn.Close();
        }
        public static void DeleteMovies()
        {
            var newDelete = Form1.delete;
            String query = string.Format("Delete from movie where title_movie = '{0}'", newDelete);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
            
        }
        public static List<Movies> CurrentValues()
        {
            List<Movies> movies = new List<Movies>();

            var newUpdateID = Form1.updateIDvalue;
            String query = String.Format("Select * from movie where id_movie = '{0}'", newUpdateID);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                int id = (int)reader["id_movie"];
                string title = reader["title_movie"].ToString();
                string description = reader["description_movie"].ToString();
                string release = reader["releaseDate_movie"].ToString();
                int length = (int)reader["length_movie"];
                int directorNumber = (int)reader["director_id_director"];

                Movies m = new Movies(id, title, description, release, length, directorNumber);

                movies.Add(m);
            }

            dbConn.Close();
            return movies;
        }
        public static void UpdateValues()
        {
            var newMovieID = UpdateForm.updateMovieId;
            var newTitle = UpdateForm.updateTitle;
            var newDesc = UpdateForm.updateDesc;
            var newRelease = UpdateForm.updateDate;
            var newLength = UpdateForm.updateLength;
            var newDirectorID = UpdateForm.updateDirectorID;

            String query = string.Format("Update movie set id_movie = '{0}', title_movie = '{1}'," +
                "description_movie = '{2}', releaseDate_movie = '{3}', length_movie = '{4}'," +
                "director_id_director = '{5}' where id_movie = '{6}'"
                , newMovieID, newTitle, newDesc, newRelease, newLength, newDirectorID, newMovieID);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);     


            dbConn.Open();

            cmd.ExecuteNonQuery();

            dbConn.Close();
        }
        public static List<Movies> GetDetailedInfo()
        {
            List<Movies> movies = new List<Movies>();

            var detailMovieID = Form1.detailInfoValue; //Select * from director
            String query = "Select movie.title_movie, movie.description_movie, movie.releaseDate_movie," +
                "movie.length_movie, director.id_Director, director.fname_Director, " +
                "director.lname_Director, director.age_Director from movie " +
                "inner join director on movie.director_id_director = director.id_director";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                string title = reader["title_movie"].ToString();
                string description = reader["description_movie"].ToString();
                string release = reader["releaseDate_movie"].ToString();
                int length = (int)reader["length_movie"];
                int directorNumber = (int)reader["id_director"];
                string fname = reader["fname_director"].ToString();
                string lname = reader["lname_director"].ToString();
                int age = (int)reader["age_director"];
                Movies m = new Movies(title, description, release, length, directorNumber, fname, lname, age);

                movies.Add(m);
            }

            dbConn.Close();
            return movies;
        }
    }
}
