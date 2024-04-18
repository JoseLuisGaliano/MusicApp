﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Windows.Media;

namespace MusicApp.Database
{
    public static class DatabaseManager
    {
        private const string connectionString = "Data Source=LAPTOP-85QOQ2U8;Initial Catalog = Search Item Database; Integrated Security = True";

        public static List<Search.SearchResultItemControl> LoadUserSearchItems(List<Search.SearchResultItemControl> searchItems)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Specify query to execute
                    string query = "SELECT * FROM [USER];";

                    // Create a SqlDataAdapter to execute the query and retrieve data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Fill a DataTable with the results of the query
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Convert each row into a search result item
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string image = row["profilePicture"].ToString();
                        string title = row["userName"].ToString();
                        string subtitle1 = "User";
                        searchItems.Add(Search.SearchWindow.AddSearchResult(image, title, subtitle1));
                    }

                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving items from the database: " + ex.Message);
            };
            return searchItems;
        }

        public static List<Search.SearchResultItemControl> LoadArtistSearchItems(List<Search.SearchResultItemControl> searchItems)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Specify query to execute
                    string query = "SELECT * FROM ARTIST;";

                    // Create a SqlDataAdapter to execute the query and retrieve data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Fill a DataTable with the results of the query
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Convert each row into a search result item
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string image = row["artistPicture"].ToString();
                        string title = row["artistName"].ToString();
                        string subtitle1 = "Artist";
                        searchItems.Add(Search.SearchWindow.AddSearchResult(image, title, subtitle1));
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving items from the database: " + ex.Message);
            };
            return searchItems;
        }

        public static List<Search.SearchResultItemControl> LoadSongSearchItems(List<Search.SearchResultItemControl> searchItems, string genreFilter = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Specify query to execute
                    string query;
                    if (genreFilter != "")
                    {
                        query = "SELECT * FROM SONG WHERE album IN ( SELECT albumId FROM ALBUM WHERE genre = '" + genreFilter + "');";
                    }
                    else
                    {
                        query = "SELECT * FROM SONG;";
                    }

                    // Create a SqlDataAdapter to execute the query and retrieve data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Fill a DataTable with the results of the query
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Convert each row into a search result item
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string title = row["songName"].ToString();

                        // Resolve the database references (foreign keys) to properly pass the data to AddSearchResult()
                        string getImageQuery = "SELECT albumPicture FROM ALBUM WHERE albumId = (SELECT album FROM SONG WHERE songName = '" + title + "');";
                        SqlCommand command = new SqlCommand(getImageQuery, connection);
                        string image = command.ExecuteScalar().ToString();

                        string getArtistQuery = "SELECT artistName FROM ARTIST WHERE artistId = ( SELECT albumArtist FROM ALBUM WHERE albumId = ( SELECT album FROM SONG WHERE songName = '" + title + "'));";
                        SqlCommand command1 = new SqlCommand(getArtistQuery, connection);
                        // Since we know the result of the select is a single element (one row and one column) we can use ExecuteScalar() to get that value
                        string subtitle1 = command1.ExecuteScalar().ToString();

                        string getDateQuery = "SELECT [date] FROM ALBUM WHERE albumId = (SELECT album FROM SONG WHERE songName = '" + title +"');";
                        SqlCommand command2 = new SqlCommand(getDateQuery, connection);
                        string subtitle2 = command2.ExecuteScalar().ToString();

                        string getGenreQuery = "SELECT genre FROM ALBUM WHERE albumId = (SELECT album FROM SONG WHERE songName = '" + title + "');";
                        SqlCommand command3 = new SqlCommand(getGenreQuery, connection);
                        string subtitle3 = command3.ExecuteScalar().ToString();

                        searchItems.Add(Search.SearchWindow.AddSearchResult(image, title, subtitle1, subtitle2, subtitle3));
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving items from the database: " + ex.Message);
            };
            return searchItems;
        }

        public static List<Search.SearchResultItemControl> LoadAlbumSearchItems(List<Search.SearchResultItemControl> searchItems, string genreFilter = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Specify query to execute
                    string query;
                    if (genreFilter != "")
                    {
                        query = "SELECT * FROM ALBUM WHERE genre = '" + genreFilter + "';";
                    }
                    else
                    {
                        query = "SELECT * FROM ALBUM;";
                    }

                    // Create a SqlDataAdapter to execute the query and retrieve data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Fill a DataTable with the results of the query
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Convert each row into a search result item
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string image = row["albumPicture"].ToString();
                        string title = row["albumName"].ToString();
                        string subtitle2 = row["date"].ToString();
                        string subtitle3 = row["genre"].ToString();

                        // Resolve the database references (foreign keys) to properly pass the data to AddSearchResult()
                        string getArtistQuery = "SELECT artistName FROM ARTIST WHERE artistId = ( SELECT albumArtist FROM ALBUM WHERE albumName = '" + title + "');";
                        SqlCommand command = new SqlCommand(getArtistQuery, connection);
                        // Since we know the result of the select is a single element (one row and one column) we can use ExecuteScalar() to get that value
                        string subtitle1 = command.ExecuteScalar().ToString();

                        searchItems.Add(Search.SearchWindow.AddSearchResult(image, title, subtitle1, subtitle2, subtitle3));
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while retrieving items from the database: " + ex.Message);
            };
            return searchItems;
        }

        // I don't think any of this is necessary - artists, albums and songs can be added directly to the database since they 
        // have nothing to do with the client. Users are added in another part of the program, too.
        // Just in case I'm keeping this here for now, though.
        /*
        public static void AddUser(string name, string image)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [USER] (userName, profilePicture) VALUES (@userName, @profilePicture);";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userName", name);
                    command.Parameters.AddWithValue("@profilePicture", image);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error while storing item in the database: " + ex.Message);
            };
        }

        public static void AddArtist(string name, string image)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while storing item in the database: " + ex.Message);
            };
        }

        public static void AddAlbum(string name, string image, string artist, string date, string genre)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while storing item in the database: " + ex.Message);
            };
        }

        public static void AddSong(string name, string album)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while storing item in the database: " + ex.Message);
            };
        }
        */

    }
}