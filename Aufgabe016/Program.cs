using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Aufgabe016
{
    class Program
    {
        //const string REGEX_PATTERN = "([A-z\\s]){1,} ((?>(?>(?>---)|(?>[0-9]:[0-9]))\\s{0,1}){18})";

        public class Game
        {
            public string team0;
            public string team1;
            public int score0;
            public int score1;
        }

        public class Verein
        {
            public string name;
            public int punkte;
            public int tore;

            public Verein(string name)
            {
                this.name = name;
            }
        }

        public static void readGames(string fileName, out List<Game> games, out List<Verein> teams)
        {
            games = new List<Game>();
            teams = new List<Verein>();
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                string name = line.Substring(0, 26).Trim();
                teams.Add(new Verein(name));
                string scoreString = line.Substring(26);
                string[] scores = scoreString.Split(' ');
                for (int i = 0; i < scores.Length; i++)
                {
                    if (scores[i].Contains("---"))
                        continue;
                    string[] parts = scores[i].Split(':');
                    int tScore0 = int.Parse(parts[0]);
                    int tScore1 = int.Parse(parts[1]);
                    string teamName = "#" + i;
                    if (teams.Count > i)
                        teamName = teams[i].name;
                    Game game = new Game()
                    {
                        team0 = name,
                        team1 = teamName,
                        score0 = tScore0,
                        score1 = tScore1
                    };
                    games.Add(game);
                }
            }
            foreach (var game in games)
            {
                var teamName = game.team1;
                if (teamName.StartsWith("#"))
                {
                    int index = int.Parse(teamName.Substring(1));
                    game.team1 = teams[index].name;
                }
            }
        }

        static void Main(string[] args)
        {
            List<Game> games;
            List<Verein> teams;
            readGames("bundesliga0809-0.txt", out games, out teams);
            calculateResults(games, teams);

            foreach (var team in teams)
            {
                Console.WriteLine("Der Verein {0,-30} hat {1} Punkte und {2} Tore", team.name, team.punkte, team.tore);
            }

            System.Threading.Thread.Sleep(10000);
        }

        private static void calculateResults(List<Game> games, List<Verein> teams)
        {
            foreach (Verein team in teams)
            {
                team.tore = (from game in games where game.team0.Equals(team.name) select game.score0).Sum();
                team.tore += (from game in games where game.team1.Equals(team.name) select game.score1).Sum();

                var playedGames = from game in games
                                  where game.team0.Equals(team.name) || game.team1.Equals(team.name)
                                  select game;
                var points = 0;
                foreach (var game in playedGames)
                {
                    var self = 0;
                    var other = 0;
                    if (game.team0.Equals(team))
                    {
                        self = game.score0;
                        other = game.score1;
                    }
                    else
                    {
                        self = game.score1;
                        other = game.score0;
                    }

                    if (self > other)
                        points += 3;
                    else if (self == other)
                        points += 1;
                }
                team.punkte = points;
            }
        }
    }
}
