using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> Users = new();

            int[] maciekMarks = {5,2,3};
            DateTime maciekDataStart = DateTime.Now;
            User maciekUser = new("maciek", "STUDENT", 21, maciekMarks, maciekDataStart);
            Users.Add(maciekUser);

            int[] KornelMarks = { 5, 5,5,5,4 };
            DateTime KornelDataStart = new DateTime(2021, 10, 13);
            DateTime KornelDataEnd = new DateTime(2021, 12, 13);
            User KornelUser = new("Kornel", "STUDENT", 21, KornelMarks, KornelDataStart, KornelDataEnd);
            Users.Add(KornelUser);

            DateTime GustawDataStart = new DateTime(2011, 11, 12);
            DateTime GustawDataEnd = new DateTime(2021, 8, 16);
            User GustawUser = new("Gustaw ", "ADMIN", 32, null, GustawDataStart, GustawDataEnd);
            Users.Add(GustawUser);

            DateTime JanDataStart = new DateTime(2015, 6, 03);
            DateTime JanDataEnd = new DateTime(2021, 12, 30);
            User JanUser = new("Jan", "ADMIN", 28, null, JanDataStart, JanDataEnd);
            Users.Add(JanUser);

            DateTime CyprianDataStart = new DateTime(2018, 1, 10);
            User CyprianUser = new("Cyprian", "ADMIN", 43, null, CyprianDataStart);
            Users.Add(CyprianUser); 

            DateTime HenrykDataStart = new DateTime(2021, 10, 13);
            DateTime HenrykDataEnd = new DateTime(2021, 12, 13);
            User HenrykUser = new("Henryk", "MODERATOR", 26, null, HenrykDataStart, HenrykDataEnd);
            Users.Add(HenrykUser);

            DateTime LeszekDataStart = new DateTime(2021, 10, 13);
            DateTime LeszekDataEnd = new DateTime(2021, 12, 13);
            User LeszekUser = new("Leszek", "MODERATOR", 21, null, LeszekDataStart, LeszekDataEnd);
            Users.Add(LeszekUser);

            DateTime IgorDataStart = new DateTime(2021, 10, 13);
            User IgorUser = new("Igor", "TEACHER", 21, null, IgorDataStart);
            Users.Add(IgorUser);

            DateTime MateuszDataStart = new DateTime(2021, 10, 13);
            DateTime MateuszDataEnd = new DateTime(2021, 12, 13);
            User MateuszUser = new("Mateusz", "TEACHER", 21, null, MateuszDataStart, MateuszDataEnd);
            Users.Add(MateuszUser);

            DateTime MarcelDataStart = new DateTime(2021, 10, 13);
            User MarcelUser = new("Marcel", "TEACHER", 21, null, MarcelDataStart);
            Users.Add(MarcelUser);

            DateTime KlaudiuszDataStart = new DateTime(2021, 10, 13);
            DateTime KlaudiuszDataEnd = new DateTime(2021, 12, 13);
            User KlaudiuszUser = new("Klaudiusz", "TEACHER", 21, null, KlaudiuszDataStart, KlaudiuszDataEnd);
            Users.Add(KlaudiuszUser);

            DateTime AntoniDataStart = new DateTime(2021, 10, 13);
            User AntoniUser = new("Antoni", "TEACHER", 21, null, AntoniDataStart);
            Users.Add(AntoniUser);

            int[] AlexanderMarks = {2,2 ,2 };
            DateTime AlexanderDataStart = new DateTime(2021, 10, 13);
            DateTime AlexanderDataEnd = new DateTime(2021, 12, 13);
            User AlexanderUser = new("Alexander", "STUDENT", 21, AlexanderMarks, AlexanderDataStart, AlexanderDataEnd);
            Users.Add(AlexanderUser);

            int[] RafalMarks = {3, 3,5,3,2,4 };
            DateTime RafalDataStart = new DateTime(2021, 10, 13);
            User RafalUser = new("Rafal", "STUDENT", 21, RafalMarks, RafalDataStart);
            Users.Add(RafalUser);

            int[] AmadeuszMarks = {3};
            DateTime AmadeuszDataStart = new DateTime(2021, 10, 13);
            User AmadeuszUser = new("Amadeusz", "STUDENT", 21, AmadeuszMarks, AmadeuszDataStart);
            Users.Add(AmadeuszUser);

            int[] BartlomiejMarks = {3,5 ,3,3,4,4 };
            DateTime BartlomiejDataStart = new DateTime(2021, 10, 13);
            User BartlomiejUser = new("Bartlomiej", "STUDENT", 21, BartlomiejMarks, BartlomiejDataStart);
            Users.Add(BartlomiejUser);

            int[] GrzegorzMarks = {4,3 ,4,3 };
            DateTime GrzegorzDataStart = new DateTime(2021, 4, 13);
            User GrzegorzUser = new("Grzegorz", "STUDENT", 21, GrzegorzMarks, GrzegorzDataStart);
            Users.Add(GrzegorzUser);

            DateTime ArielDataStart = new DateTime(2021, 3, 13);
            DateTime ArielDataEnd = new DateTime(2021, 12, 13);
            User ArielUser = new("Ariel", "TEACHER", 21, null, ArielDataStart, ArielDataEnd);
            Users.Add(ArielUser);

            DateTime MilanDataStart = new DateTime(2021, 1, 13);
            DateTime MilanDataEnd = new DateTime(2021, 12, 13);
            User MilanUser = new("Milan", "TEACHER", 21, null, MilanDataStart, MilanDataEnd);
            Users.Add(MilanUser);

            DateTime JacekDataStart = new DateTime(2021, 2, 13);
            User JacekUser = new("Jacek", "TEACHER", 21, null, JacekDataStart);
            Users.Add(JacekUser);

            var q1 = (from user in Users select user).Count();

            Console.WriteLine($"1. {q1}\n");

            var q2 = from user in Users select user.Name;
            Console.WriteLine("2.");
            foreach(var user in q2)
            {
                Console.WriteLine($"{user}");
            }
            Console.WriteLine();

            var q3 = from user in Users orderby user.Name  select user.Name;
            Console.WriteLine("3.");
            foreach (var user in q3)
            {
                Console.WriteLine($"{user}");
            }
            Console.WriteLine();

            var q4 = (from user in Users select user.Role).Distinct();
            Console.WriteLine("4.");
            foreach (var user in q4)
            {
                Console.WriteLine($"{user}");
            }
            Console.WriteLine();

            var q5 = from user in Users orderby user.Role select user ;
            Console.WriteLine("5.");
            foreach (var user in q5)
            {
                Console.WriteLine($"{user.Role} {user.Name}");
            }
            Console.WriteLine();

            var q6 = (from user in Users where user.Marks != null && user.Marks.Count() > 0 select user).Count();
            Console.WriteLine($"6. {q6}\n");

            var q7 = from user in Users where user.Marks != null && user.Marks.Count() > 0 select user;
            Console.WriteLine("7.");
            foreach (var user in q7)
            {
                var sum = (from b in user.Marks select b).Sum();
                var count = (from c in user.Marks select c).Count();
                var average = (from d in user.Marks select d).Average();
                Console.WriteLine($"{user.Name} Sum = {sum} Count = {count} Average = {Math.Round(average,2)}");
            }
            Console.WriteLine();

            Console.WriteLine("8.");
            foreach (var user in q7)
            {
                var max = (from b in user.Marks select b).Max();
                Console.WriteLine($"{user.Name} the best score= {max} ");
            }
            Console.WriteLine();

            Console.WriteLine("9.");
            foreach (var user in q7)
            {
                var min = (from b in user.Marks select b).Min();
                Console.WriteLine($"{user.Name} worst score= {min} ");
            }
            Console.WriteLine();

            Console.WriteLine("10.");
            double beststudent = 0;
            foreach (var user in q7)
            {
                var average = (from d in user.Marks select d).Average();
                if (average > beststudent) beststudent = average;
            }

            var q10 = from user in Users where user.Marks != null && user.Marks.Count() > 0 && ((from d in user.Marks select d).Average()) == beststudent select user;
            foreach(var user in q10)
            {
                Console.WriteLine(user.Name);
            }
            Console.WriteLine();

            Console.WriteLine("11.");
            var minCount = 5;
            foreach (var user in q7)
            {
                var count = (from c in user.Marks select c).Count();
                if (minCount > count) minCount = count;
            }
            var q11 = from user in Users where user.Marks != null && user.Marks.Count() > 0 && ((from c in user.Marks select c).Count()) == minCount select user;
            foreach (var user in q11)
            {
                Console.WriteLine(user.Name);
            }
            Console.WriteLine();

            Console.WriteLine("12.");
            var maxCount = 0;
            foreach (var user in q7)
            {
                var count = (from c in user.Marks select c).Count();
                if (maxCount < count) minCount = count;
            }
            var q12 = from user in Users where user.Marks != null && user.Marks.Count() > 0 && ((from c in user.Marks select c).Count()) == maxCount select user;
            foreach (var user in q11)
            {
                Console.WriteLine(user.Name);
            }
            Console.WriteLine();

            /*q13*/

            Console.WriteLine("14.");
            var q14 = from user in Users where user.Marks != null && user.Marks.Count() > 0 orderby ((from d in user.Marks select d).Average()) descending select user;
            foreach(var user in q14)
            {
                Console.WriteLine($"{user.Name} {Math.Round((from d in user.Marks select d).Average(), 2)}");
            }
            Console.WriteLine();

            Console.WriteLine("15.");
            foreach(var user in q7)
            {
                Console.WriteLine(Math.Round((from d in user.Marks select d).Average(), 0));
            }
            Console.WriteLine();

            Console.WriteLine("16.");
            var q16 = Users.GroupBy(user => user.CreatedAt).Select(user => user.Key).ToList();
            foreach (var user in q16)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine();

            Console.WriteLine("17.");
            var now = DateTime.Now;
            var q17 = from user in Users where user.RemovedAt == null select user;
            foreach (var user in q17)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("18.");
            DateTime? newStudent = new(1, 10, 13);
            var q18 = from user in Users where user.Role == "STUDENT" && user.CreatedAt != null select user;
            foreach (var user in q18)
            {
                if (newStudent < user.CreatedAt) newStudent = user.CreatedAt;
            }
            Console.WriteLine(newStudent);
            Console.WriteLine();

            ///*JSON*/
            //List<User> json = new();
            //foreach (var user in Users)
            //{
            //    json.Add(user);
            //    Console.WriteLine(user);
            //}
            ////string usersSerializeJSON = JsonSerializer.Serialize(Users);
            ////Console.WriteLine($"{usersSerializeJSON}\n");

            ////string maciekSerializeJSON = JsonSerializer.Serialize(maciekUser);
            ////Console.WriteLine(maciekSerializeJSON);

            //foreach(var user in Users)
            //{
            //    var end = (user.RemovedAt != null) ? "\",\"RemovedAt\":" + user.RemovedAt + "}" : "}";
            //    var jsonD = "{\"Name\":\"" + user.Name + "\",\"Role\":" + user.Role + "\",\"Age\":" + user.Age +
            //       "\",\"Marks\":" + user.Marks + "\",\"CreatedAt\":" + user.CreatedAt + end;
            //       ;

            //    User usersDeserializeJSON = JsonSerializer.Deserialize<User>(jsonD);
            //    Console.WriteLine($"Name: {usersDeserializeJSON.Name}");
            //    Console.WriteLine($"Role: {usersDeserializeJSON.Role}");
            //    Console.WriteLine($"Age: {usersDeserializeJSON.Age}");
            //    Console.WriteLine($"Marks: {usersDeserializeJSON.Marks}");
            //    Console.WriteLine($"Created at: {usersDeserializeJSON.CreatedAt}");
            //    Console.WriteLine($"Removed at: {usersDeserializeJSON.RemovedAt}");
            //    Console.WriteLine();
            //}
        }
    }
}
