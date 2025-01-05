using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.domain
{
    public class Movie
    {
        private int _id;
        public int Id { get { return _id; }set { _id = value; } }
        private String genre;
        public String Genre { get { return genre; }set { genre = value; } }
        private String name;
        public String Name { get { return name; } set { name = value; } }

        public Movie() { }
        public Movie(int id, string genre, string name)
        {
            Id = id;
            Genre = genre;
            Name = name;
        }
    }
}
