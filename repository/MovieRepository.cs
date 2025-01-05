using ConsoleApp3.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.repository
{

    public class MovieRepository
    {
        private Movie[] movies = new Movie[0];

        public void Save(Movie movie)
        {
            Movie[] tmp = new Movie[movies.Length + 1];
            for (int i = 0; i < movies.Length; i++)
            {
                tmp[i] = movies[i];
            }
            tmp[movies.Length] = movie;

            movies = tmp;
        }

        public void RemoveById(int id)
        {
            Movie[] tmt = new Movie[movies.Length - 1];
            int index = 0;
            foreach (Movie movie in movies)
            {
                if (movie.Id != id)
                {
                    tmt[index] = movie;
                    index++;
                }
                movies = tmt;
            }
        }
        public Movie[] GetAllMovies()
        {
            return movies;
        }

        public Movie FindById(int id)
        {
            foreach (Movie movie in movies)
            {
                if (movie.Id == id)
                {
                    return movie;
                }
            }
            return null;
        }

        public Movie[]  RemoveAll()
        {
            Movie[] tmp = new Movie[0];
            movies = tmp;
            return movies;
        }
    }
    
}
