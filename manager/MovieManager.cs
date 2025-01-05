using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.domain;
using ConsoleApp3.repository;

namespace ConsoleApp3.manager
{
    public class MovieManager
    {
        private readonly MovieRepository _repository; 
        private int resultLentgh = 3;

        //Конструкторы

        public MovieManager(int result, MovieRepository repository)
        {
            this.resultLentgh = result;
            this._repository = repository;
        }
        public MovieManager(MovieRepository repository)
        {
            this._repository= repository;
        }

        public MovieManager() { }


        //Методы

        public Movie[] GetMovies()
        {
            return _repository.GetAllMovies();
        }

        public Movie[] GetLast()
        {
            var result = _repository.GetAllMovies();
            Movie[] tmp = new Movie[Math.Min(result.Length, resultLentgh)];
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = result[result.Length - i - 1];
            }
            return tmp;
        }

        public void Add(Movie item)
        {
            _repository.Save(item);
        }


        public void Delete(int id)
        {
          _repository.RemoveById(id);
        }

        public Movie[] DeleteAll()
        {
            Movie[]items= _repository.RemoveAll();
            return items;
        }
    }
}
