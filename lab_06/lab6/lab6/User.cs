using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public User(string name, string role,int age, int[] marks, DateTime createdAt, DateTime removeAt)
        {
            Name = name;
            Role = role;
            Age = age;
            Marks = marks;
            CreatedAt = createdAt;
            RemovedAt = removeAt;
        }

        public User(string name, string role, int age, int[] marks, DateTime createdAt)
        {
            Name = name;
            Role = role;
            Age = age;
            Marks = marks;
            CreatedAt = createdAt;
            RemovedAt = null;
        }

        private string GetMarks() => $"[ {string.Join(" ", Marks)} ]";
        public override string ToString() => $"{Name} {Role} {Age} {((Marks != null) ? GetMarks() : null)} {CreatedAt} {RemovedAt}";
    }
}
