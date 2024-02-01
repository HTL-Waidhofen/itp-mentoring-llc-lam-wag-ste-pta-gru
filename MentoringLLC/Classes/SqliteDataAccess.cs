using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Text.Json.Nodes;
using System.Reflection;
using MentoringLLC.Classes;

public class SqliteDataAccess
{
    public static User GetUserbyEmail(string email)
    {
        using (var con = new SQLiteConnection(loadConnectionString()))
        {
            con.Open();
            User ma = new User();
            using (var cmd = new SQLiteCommand(con))
            {
                Console.WriteLine("connected");
                cmd.CommandText = "SELECT * FROM LLC_USERS WHERE email = @email";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        ma.Email = rdr.GetString(0);
                        ma.Username = rdr.GetString(1);
                        ma.Password = rdr.GetString(2);
                        ma.Nickname = rdr.GetString(3);
                        ma.Bild = rdr.GetString(4);
                        ma.IsBanned = rdr.GetInt32(5);
                        ma.TimeBanned = rdr.GetInt32(6);
                        ma.UntilBanned = rdr.GetInt32(7);
                        ma.IsAdmin = rdr.GetInt32(8);
                        ma.IsMentor = rdr.GetInt32(9);
                    }

                }
            }
            return ma;
        }
    }
    public static User GetUserbyUsername(string username)
    {
        using (var con = new SQLiteConnection(loadConnectionString()))
        {
            con.Open();
            User ma = new User();
            using (var cmd = new SQLiteCommand(con))
            {
                Console.WriteLine("connected");
                cmd.CommandText = "SELECT * FROM LLC_USERS WHERE username = @username";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        ma.Email = rdr.GetString(0);
                        ma.Username = rdr.GetString(1);
                        ma.Password = rdr.GetString(2);
                        ma.Nickname = rdr.GetString(3);
                        ma.Bild = rdr.GetString(4);
                        ma.IsBanned = rdr.GetInt32(5);
                        ma.TimeBanned = rdr.GetInt32(6);
                        ma.UntilBanned = rdr.GetInt32(7);
                        ma.IsAdmin = rdr.GetInt32(8);
                        ma.IsMentor = rdr.GetInt32(9);
                    }

                }
            }
            return ma;
        }
    }
    public static List<string> GetUsers()
    {
        List<string> users = new List<string>();
        using (var con = new SQLiteConnection(loadConnectionString()))
        {
            con.Open();
            using (var cmd = new SQLiteCommand(con))
            {
                Console.WriteLine("connected");
                cmd.CommandText = "SELECT username FROM LLC_USERS";
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while(rdr.Read())
                    {
                        users.Add(Convert.ToString(rdr["username"]));
                    }
                }
            }
            return users;
        }
    }
    //public static List<string> loadMA()
    //{
    //    using (var con = new SQLiteConnection(loadConnectionString()))
    //    {
    //        con.Open();
    //        List<string> plist = new List<string>();
    //        string stm = "SELECT * FROM User where PersNr";

    //        using (var cmd = new SQLiteCommand(stm, con))
    //        {
    //            using (SQLiteDataReader rdr = cmd.ExecuteReader())
    //            {
    //                while (rdr.Read())
    //                {
    //                    User ma = new User();
    //                    ma.Email = rdr.GetString(0);
    //                    ma.Username = rdr.GetString(1);
    //                    ma.Password = rdr.GetString(2);
    //                    ma.Nickname = rdr.GetString(3);
    //                    ma.Bild = rdr.GetString(4);
    //                    ma.IsBanned = rdr.GetInt32(5);
    //                    ma.TimeBanned = rdr.GetInt32(6);
    //                    ma.UntilBanned = rdr.GetInt32(7);
    //                    ma.IsAdmin = rdr.GetInt32(8);
    //                    ma.IsMentor = rdr.GetInt32(9);
    //                }
    //                return ;
    //            }
    //        }
    //    }
    //}
    public static void AddUser(User user)
    {
        using (var con = new SQLiteConnection(loadConnectionString()))
        {
            con.Open();

            using (var cmd = new SQLiteCommand(con))
            {
                cmd.CommandText = "INSERT INTO LLC_USERS(email, username, pw, nickname, bild,isBanned,bannedTime,untilBanned,isAdmin,isMentor) VALUES(@email,@username,@pw,@nickname,@bild,@isBanned,@TimeBanned,@UntilBanned,@isAdmin,@isMentor)";
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@pw", user.Password);
                cmd.Parameters.AddWithValue("@nickname", user.Nickname);
                cmd.Parameters.AddWithValue("@bild", user.Bild);
                cmd.Parameters.AddWithValue("@isBanned", user.IsBanned);
                cmd.Parameters.AddWithValue("@TimeBanned", user.TimeBanned);
                cmd.Parameters.AddWithValue("@UntilBanned", user.UntilBanned);
                cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
                cmd.Parameters.AddWithValue("@isMentor", user.IsMentor);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
        }
    }

    public static void UpdateUser(User user)
    {
        using (var con = new SQLiteConnection(loadConnectionString()))
        {
            con.Open();

            using (var cmd = new SQLiteCommand(con))
            {
                cmd.CommandText = "UPDATE LLC_USERS SET username = @username, pw = @pw, nickname = @nickname, bild = @bild, isBanned = @isBanned, bannedTime = @TimeBanned, untilBanned = @UntilBanned, isAdmin = @isAdmin, isMentor = @isMentor WHERE email = @email";
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@pw", user.Password);
                cmd.Parameters.AddWithValue("@nickname", user.Nickname);
                cmd.Parameters.AddWithValue("@bild", user.Bild);
                cmd.Parameters.AddWithValue("@isBanned", user.IsBanned);
                cmd.Parameters.AddWithValue("@TimeBanned", user.TimeBanned);
                cmd.Parameters.AddWithValue("@UntilBanned", user.UntilBanned);
                cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
                cmd.Parameters.AddWithValue("@isMentor", user.IsMentor);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.ExecuteNonQuery();

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }
    }
    public static void RemoveUser(User person)
    {
        using (var con = new SQLiteConnection(loadConnectionString()))
        {
            con.Open();

            using (var cmd = new SQLiteCommand(con))
            {
                cmd.CommandText = "DELETE FROM LLC_USERS WHERE email=@email;";
                cmd.Parameters.AddWithValue("@persnr", person.Email);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }
    }

    private static string loadConnectionString()
    {
        return "DataSource=./data.db;Version=3;";
    }
}

