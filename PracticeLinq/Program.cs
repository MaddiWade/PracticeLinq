using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>();
           

            videoGames.Add("Call Of Duty");
            videoGames.Add("Halo");
            videoGames.Add("Rainbow 6");
            videoGames.Add("OverWatch");
            videoGames.Add("Fallout");
            videoGames.Add("Madden");

            
            List<string> gameLength = videoGames.OrderBy(videoGames => videoGames).ToList();
            foreach(var game in gameLength)
                Console.WriteLine(game);
        }
    }
}
