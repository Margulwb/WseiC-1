using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace lab6
{
    public class User
    {
        public string Name { get; set; }
        public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT
        public int Age { get; set; }
        public int[] Marks { get; set; } // zawsze null gdy ADMIN, MODERATOR lub TEACHER
        public DateTime? CreatedAt { get; set ; }
        public DateTime? RemovedAt { get; set; }

        [JsonConstructor]
        public User(string name, string role, int age, int[] marks, DateTime createdAt)
        {
            Name = name;
            Role = role;
            Age = age;
            Marks = marks;
            CreatedAt = createdAt;
            RemovedAt = null;
        }

        [JsonConstructor]
        public User(string name, string role,int age, int[] marks, DateTime createdAt, DateTime removeAt)
        {
            Name = name;
            Role = role;
            Age = age;
            Marks = marks;
            CreatedAt = createdAt;
            RemovedAt = removeAt;
        }

        private string GetMarks() => $"[ {string.Join(" ", Marks)} ]";
        public override string ToString() => $"{Name} {Role} {Age} {((Marks != null) ? GetMarks() : null)} {CreatedAt} {RemovedAt}";
    }
}
