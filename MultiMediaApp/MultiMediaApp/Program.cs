// See https://aka.ms/new-console-template for more information
using MovieApp;

Console.WriteLine("Hello, World!");


var movie = new Movie("Adults Only");

var john = new MovieGoer(20);
john.WatchMovie(movie);

var jane = new MovieGoer(12);
jane.WatchMovie(movie);

