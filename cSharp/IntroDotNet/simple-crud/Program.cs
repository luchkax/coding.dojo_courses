using System;
using DbConnection;
// using System.Collections.Generic;


namespace simple_crud
{
    class Program
    {
        public static void read()
        {
            var allUsers = DbConnector.Query("SELECT * FROM users");

            foreach(var user in allUsers)
            {
                System.Console.WriteLine($"{user["first_name"]} {user["last_name"]}, {user["favorite_number"]}");
            }
        }

        public static void create()
        {
            System.Console.WriteLine("Enter first name:");
            string firstName = '"' + Console.ReadLine() + '"';
            System.Console.WriteLine("Enter last name:");
            string lastName = '"'+Console.ReadLine()+'"';
            System.Console.WriteLine("Enter lucky number:");
            string favoriteNumber = Console.ReadLine();
            string query = $"INSERT INTO users(first_name, last_name, favorite_number) VALUES({firstName}, {lastName}, {favoriteNumber})";
            DbConnector.Execute(query);
            read();
        }

        public static void update()
        {
            System.Console.WriteLine("Enter user id:");
            string id = '"'+Console.ReadLine()+'"';
            System.Console.WriteLine("Enter first name:");
            string firstName = '"'+Console.ReadLine()+'"';
            System.Console.WriteLine("Enter last name:");
            string lastName = '"'+Console.ReadLine()+'"';
            System.Console.WriteLine("Enter lucky number:");
            string favoriteNumber = Console.ReadLine();
            string updateQuery = $"UPDATE users SET first_name = {firstName}, last_name = {lastName}, favorite_number = {favoriteNumber} WHERE idusers = {id}";
            DbConnector.Execute(updateQuery);
            read();
        }
        
        public static void remove()
        {
            System.Console.WriteLine("Enter user id which you want to remove:");
            string id = '"'+Console.ReadLine()+'"';
            string deleteQuery = $"DELETE FROM users WHERE idusers = {id}";
            DbConnector.Execute(deleteQuery);
            read();
        }

        static void Main(string[] args)
        {
            remove();
            
        }
    }
}
