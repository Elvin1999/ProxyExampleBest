using System;
using System.Linq;

namespace Proxy
{
    class Program
    {
            static void Main(string[] args)
            {
                IMovieSearcher searcher = new LocalMovieSearcher(new GlobalMovieSearcher());   //LocalMovieSearcher -proxy
                while (true)
                {

                    Console.Write("Serch: ");
                    ShowMovieData(searcher.SearchByTitle(Console.ReadLine()));
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            public static void ShowMovieData(Movie movie)
            {
                Console.WriteLine($"Country: {movie.Country}\nDirected by: {movie.Director}\n" +
                    $"Genre: {movie.Genre}\nActors: {movie.Actors}\n\n");
            }
    }
    
}
