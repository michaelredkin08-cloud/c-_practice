using System;
using static System.Console;
namespace ObjectOrientedChallengeFootball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare
            int numOfTeams = 5; // Number o teams if odd there will be bye-in;
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
                
            }while();
            
        }
    }
}
