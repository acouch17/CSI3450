using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSI3450_MovieDatabase
{
    public class Movie
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "csi3450_phase2";
        private const String UID = "root";
        private const String PASSWORD = "TacoBell1";
        private static MySqlConnection dbConn;
        
        public int id_Movie { get; private set; }
        public String title_Movie { get; private set; }
        public String description_Movie { get; private set; }
        public String releaseDate_Movie { get; private set; }
        public int length_Movie { get; private set; }
        public int Director_id_Movie { get; private set; }

        private Movie(int id, string title, string description, string releaseDate, int length, int directorID)
        {
            id_Movie = id;
            title_Movie = title;
            description_Movie = description;
            releaseDate_Movie = releaseDate;
            length_Movie = length;
            Director_id_Movie = directorID;
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
        public static List<Movie> GetMovies()
        {
            return null;
        }
        public static Movie Insert(string title, string description, string releaseDate, int length, int directorID)
        {
            return null;
        }
        public void update(string title, string description, string releaseDate, int length, int directorID)
        {
            
        }
        public void delete()
        {

        }
    }
}
