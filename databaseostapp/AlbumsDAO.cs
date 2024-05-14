using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace databaseostapp
{
    internal class AlbumsDAO
    {
        public string connectionstring = "datasource=localhost;port=3306;username=root;password=root;database=sonic_ost;";

        public List<Album> getallalbums()
        {
            //empty list
            List<Album> returnthese = new List<Album>();

            //connect to sql server
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            //define sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("SELECT ID,VIDEOGAME,ALBUM_TITLE,ARTIST,YEAR,IMAGE_NAME,DESCRIPTION FROM ALBUMS", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        Videogame = reader.GetString(1),
                        Albumname = reader.GetString(2),
                        Artistname = reader.GetString(3),
                        Year = reader.GetInt32(4),
                        ImageURL = reader.GetString(5),
                        Description = reader.GetString(6)

                    };
                    a.Tracks = getracks(a.ID);
                    returnthese.Add(a);
                }
            }
            connection.Close();

            return returnthese;

        }

        public List<Album> searchtitles(String searchterm)
        {
            //empty list
            List<Album> returnthese = new List<Album>();

            //connect to sql server
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            String searchphrase = "%" + searchterm + "%";
            //define sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID,VIDEOGAME,ALBUM_TITLE,ARTIST,YEAR,IMAGE_NAME," +
                "DESCRIPTION FROM ALBUMS WHERE ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchphrase);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        Videogame = reader.GetString(1),
                        Albumname = reader.GetString(2),
                        Artistname = reader.GetString(3),
                        Year = reader.GetInt32(4),
                        ImageURL = reader.GetString(5),
                        Description = reader.GetString(6)

                    };
                    returnthese.Add(a);
                }
            }
            connection.Close();

            return returnthese;

        }

        internal int addonealbum(Album album)
        {
            // empty list
            List<Album> returnthese = new List<Album>();

            //connect to sql server
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            //define sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`VIDEOGAME`, `ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@vg,@album,@artist,@year,@img,@desc)", connection);
            command.Parameters.AddWithValue("@vg", album.Videogame);
            command.Parameters.AddWithValue("@album", album.Albumname);
            command.Parameters.AddWithValue("@artist", album.Artistname);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@img", album.ImageURL);
            command.Parameters.AddWithValue("@desc", album.Description);

            int newrows = command.ExecuteNonQuery();
            connection.Close();

            return newrows;
        }
        public List<Track> getracks(int albumID)
        {
            //empty list
            List<Track> returnthese = new List<Track>();

            //connect to sql server
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();

            //define sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID LIKE @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        lyrics = reader.GetString(2),
                        videourl = reader.GetString(3),
                        number = reader.GetInt32(4)


                    };
                    returnthese.Add(t);
                }
            }
            connection.Close();

            return returnthese;

        }
        public List<JObject> getracksusingjoin(int albumID)
        {
            //empty list
            List<JObject> returnthese = new List<JObject>();

            //connect to sql server
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();

            //define sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT albums.ID as albumID,tracks.ID as trackID,albumS.ALBUM_TITLE,`title`, `lyrics`, `videoURL` FROM `tracks` JOIN albums ON albums_ID=albums.ID WHERE albums_ID=@albumID";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    JObject newtrack = new JObject();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newtrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                    returnthese.Add(newtrack);
                }
            }
            connection.Close();

            return returnthese;

        }

        public List<Track> deletealbum(int albumID)
        {
            //empty list
            List<Track> returnthese = new List<Track>();

            //connect to sql server
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();

            //define sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM `albums` WHERE ID LIKE @albumID";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        lyrics = reader.GetString(2),
                        videourl = reader.GetString(3),
                        number = reader.GetInt32(4)


                    };
                    returnthese.Add(t);
                }
            }
            connection.Close();

            return returnthese;


        }

        internal int deletetrack(int trackid)
        {
            // empty list
            List<Album> returnthese = new List<Album>();

            //connect to sql server
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            //define sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("DELETE FROM `tracks` WHERE ID LIKE @trackid", connection);
            command.Parameters.AddWithValue("@trackid", trackid);


            int newrows = command.ExecuteNonQuery();
            connection.Close();

            return newrows;
        }
        public int numalbum()
        {
            List<Album> returnthese = new List<Album>();

            //connect to sql server
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            //define sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("SELECT ID,VIDEOGAME,ALBUM_TITLE,ARTIST,YEAR,IMAGE_NAME,DESCRIPTION FROM ALBUMS", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        Videogame = reader.GetString(1),
                        Albumname = reader.GetString(2),
                        Artistname = reader.GetString(3),
                        Year = reader.GetInt32(4),
                        ImageURL = reader.GetString(5),
                        Description = reader.GetString(6)

                    };
                    a.Tracks = getracks(a.ID);
                    returnthese.Add(a);
                }
            }
            connection.Close();

            return returnthese.Count;

        }
        public List<Album> getalbumname()
        {
            List<Album> returnthese = new List<Album>();
            string[] albumname;
            //connect to sql server
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            //define sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("SELECT ALBUM_TITLE FROM ALBUMS", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        
                        Albumname = reader.GetString(0),
                       

                    };
                    a.Tracks = getracks(a.ID);
                    returnthese.Add(a);
                }
            }
            connection.Close();


            return returnthese;

        }
    }
    
}
