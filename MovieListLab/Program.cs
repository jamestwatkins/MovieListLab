using System;
using System.Collections.Generic;

namespace MovieListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Shrek", "Animated"));
            movies.Add(new Movie("Up", "Animated"));
            movies.Add(new Movie("Mulan", "Animated"));
            movies.Add(new Movie("John Wick", "Action"));
            movies.Add(new Movie("Baby Driver", "Action"));
            movies.Add(new Movie("Taken", "Action"));
            movies.Add(new Movie("Lord of the Rings", "Fantasy"));
            movies.Add(new Movie("Star Wars", "Fantasy"));
            movies.Add(new Movie("Sleepaway Camp", "Horror"));
            movies.Add(new Movie("Nightmare on Elm Street", "Horror"));

            

            Console.WriteLine("Welcome to My Movie List!");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Dictionary<int, string> numGenre = new Dictionary<int, string>();

            numGenre.Add(1, "Animated");
            numGenre.Add(2, "Action");
            numGenre.Add(3, "Fantasy");
            numGenre.Add(4, "Horror");

            int numInput = 0;

            string input = "";

            bool isGenre = true;

            

            while (true)
            {

                Console.WriteLine("Which genre would you like to see? 1.Animated, 2.Action, 3.Fantasy, or 4.Horror?");

                input = Console.ReadLine();

                Console.WriteLine();

                bool isNum = int.TryParse(input, out numInput);

                if (isNum)
                {

                    if (numInput > 0 && numInput < 5)
                    {
                        input = numGenre[numInput];

                        
                    }
                    else
                    {
                        Console.WriteLine("Please choose a valid genre:");

                        continue;
                    }

                    

                }

                for (int i = 1; 1 <+ numGenre.Count; i++)
                {
                    try
                    {
                        if (numGenre[i] == input)
                        {
                            isGenre = true;
                            break;
                        }
                    }
                    catch
                    {
                        isGenre = false;
                        break;
                    }



                }

                if (isGenre)
                {
                    foreach(Movie movie in movies)
                    {
                        if(input == movie.Genre)
                        {
                            Console.WriteLine(movie.Title);
                        }


                    }
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Please enter a valid genre");
                    continue;
                }

                Console.WriteLine("Would you like to pick another genre? y to continue.");

                string response = Console.ReadLine().ToLower();

                Console.WriteLine();

                if(response == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Goodbye!");
            

        }
    }
}
