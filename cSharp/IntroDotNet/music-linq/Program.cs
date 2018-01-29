using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var artists = from idol in Artists.Where(str=>str.Hometown == "Mount Vernon") select new {idol.RealName, idol.Age, idol.Hometown};
            foreach (var item in artists)
            {
                System.Console.WriteLine($"Artist who is from {item.Hometown} is {item.RealName}, {item.Age} yearls old.");
            }
            System.Console.WriteLine("-----------------------------------");

            //Who is the youngest artist in our collection of artists?
            var yartist = from idol in Artists
                orderby idol.Age
                select new {idol.RealName, idol.Age};
            yartist = yartist.Take(1);
            foreach (var item in yartist)
            {
                System.Console.WriteLine($"The youngest artist is {item.RealName}, age of {item.Age}.");
            }
            System.Console.WriteLine("-----------------------------------");

            //Display all artists with 'William' somewhere in their real name
            var artistname = from idol in Artists.Where(str=>str.RealName.Contains("William")) select new {idol.RealName};
            System.Console.WriteLine("These are artists with name William:");
            foreach (var item in artistname)
            {
                System.Console.WriteLine(item.RealName);
            }
            System.Console.WriteLine("-----------------------------------");

            //Display the 3 oldest artist from Atlanta
            var ghettoartist = from idol in Artists.Where(str=>str.Hometown == "Atlanta")
                orderby idol.Age descending
                select new {idol.RealName, idol.Age, idol.Hometown};
            ghettoartist = ghettoartist.Take(3);
            System.Console.WriteLine("All oldest artists from Atlanta:");
            foreach (var item in ghettoartist)
            {
                System.Console.WriteLine(item.RealName, item.Age);
            }
            System.Console.WriteLine("-----------------------------------");
            
            // Display all groups with names less than 8 characters in length.
            var groups = from band in Groups.Where(str=>str.GroupName.Length < 8)
                select new {band.GroupName};
            System.Console.WriteLine("All groups with group name less than 8 char:");
            foreach (var item in groups)
            {
                System.Console.WriteLine(item.GroupName);
            }


            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
