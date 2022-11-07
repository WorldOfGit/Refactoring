using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class MovieGoer
    {
        int Age;
        internal MovieGoer(int age) => this.Age = age;

       

        internal void WatchMovie(Movie movie)
        {
            if ((this.Age < 18) && (movie.Rate.Equals("Adults Only")))
                throw new Exception("You are too young to watch this movie");

            Console.WriteLine("Watching the movie");
        }

        //void WatchXratedMovie()
        //{
        //    if (this.Age < 18)
        //        throw new Exception("Too young for this movie");
        //    else WatchMovie();
        //}

    }
}
