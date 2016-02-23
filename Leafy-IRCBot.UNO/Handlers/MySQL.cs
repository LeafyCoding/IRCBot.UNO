// -----------------------------------------------------------
// This program is private software, based on C# source code.
// To sell or change credits of this software is forbidden,
// except if someone approves it from the LeafyCoding INC. team.
// -----------------------------------------------------------
// Copyrights (c) 2016 Leafy-IRCBot.UNO INC. All rights reserved.
// -----------------------------------------------------------

#region

using System;
using Leafy_IRCBot.UNO.Classes;
using MySql.Data.MySqlClient;

#endregion

namespace Leafy_IRCBot.UNO.Handlers
{
    internal static class MySQL
    {
        private static string DB_ConnectionString = string.Empty;
        private static MySqlConnection DB_Connection;

        private static void InitMySQL()
        {
            DB_ConnectionString =
                $"host={Config.DB_Address};user={Config.DB_User};password={Config.DB_Password};database={Config.DB_Database};port={Config.DB_Port};";
            DB_Connection = new MySqlConnection(DB_ConnectionString);
        }

        public static bool TestMySQL()
        {
            if (DB_Connection == null)
            {
                InitMySQL();
            }
            if (OpenConnection())
            {
                try
                {
                    new MySqlCommand("SELECT * FROM `users` WHERE `id` = 1", DB_Connection).ExecuteReader();
                    CloseConnection();

                    return true;
                }
                catch (Exception ex)
                {
                    Tools.ColoredWrite(ConsoleColor.DarkRed, $"{ex.GetType().Name}: {ex.Message}");
                    Tools.ColoredWrite(ConsoleColor.Red, "An error was encountered while testing MySQL connection.");
                    Console.ReadKey();
                }
            }
            return false;
        }

        private static bool OpenConnection()
        {
            try
            {
                DB_Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Tools.ColoredWrite(ConsoleColor.Red,
                            "[MySQL:Err] Cannot connect to server. Contact administrator");
                        break;

                    case 1045:
                        Tools.ColoredWrite(ConsoleColor.Red, "[MySQL:Err] Invalid username/password, please try again");
                        break;

                    default:
                        Tools.ColoredWrite(ConsoleColor.Red, ex.Message);
                        break;
                }

                Console.ReadKey();
                return false;
            }
        }

        private static void CloseConnection()
        {
            try
            {
                DB_Connection.Close();
            }
            catch (Exception ex)
            {
                Tools.ColoredWrite(ConsoleColor.DarkRed, $"{ex.GetType().Name}: {ex.Message}");
            }
        }

        public static void InitUsers()
        {
            if (OpenConnection())
            {
                try
                {
                    const string cmd = "SELECT `name` FROM `users`;";
                    Tools.SemiColoredWrite(ConsoleColor.Magenta, "[MySQL] ", cmd);
                    var MySQL_Command = new MySqlCommand(cmd, DB_Connection);
                    var dataReader = MySQL_Command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        User.Users.Add(dataReader["name"].ToString().ToLower());
                    }
                    dataReader.Close();

                    var _s = User.Users.Count > 1 || User.Users.Count == 0 ? "s" : string.Empty;
                    Tools.SemiColoredWrite(ConsoleColor.Magenta, "[MySQL:InitUsers] ",
                        $"Loaded {User.Users.Count} user{_s}.");

                    CloseConnection();
                }
                catch (Exception ex)
                {
                    Tools.ColoredWrite(ConsoleColor.DarkRed, $"{ex.GetType().Name}: {ex.Message}");
                    Tools.ColoredWrite(ConsoleColor.Red, "An error was encountered while initializing users.");
                }
            }
        }
    }
}