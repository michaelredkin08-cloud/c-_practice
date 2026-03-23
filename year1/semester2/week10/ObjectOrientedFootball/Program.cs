using System;
using static System.Console;
namespace ObjectOrientedChallengeFootball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare
            int numOfTeams = 5, numOfMatches = 0; // Number of teams if odd there will be bye-in;

            List<Team> team = new List<Team>();
            for (int i = 0; i < numOfTeams; i++)//Entering the name for all the teams
            {
                WriteLine("Enter the team Name ");
                team[i].Name = ReadLine();
                WriteLine("Is it home or away team");
                team[i].Place = ReadLine();
            }
            do
            {
                for (int i = numOfTeams; i > 0; i--)
                {
                    if (i == 1 && numOfTeams % 2 != 0)
                    {
                        team[i].Result = "Automatic Win";
                        team[i].Round = numOfMatches + 1;
                        team[i].ByeIn = "Yes";
                    }
                    WriteLine($"Enter the Result for the team {team[i].Name} , is it win or loss , leave byeIn to the last team");
                    team[i].Result = ReadLine();
                    team[i].Round = numOfMatches + 1;
                    numOfMatches++;
                }


            } while ();

        }
    }
}
