using System;
using smashgg.net.Logic;

namespace smashgg.net.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var smashggNetClient = new SmashggNetClient(Environment.GetEnvironmentVariable("token"));
            
            var tournamentSlug = Console.ReadLine();
            var tournament = smashggNetClient.TournamentEndpoint.GetBySlugAsync(tournamentSlug).GetAwaiter().GetResult();
            var events = smashggNetClient.TournamentEndpoint.GetEventsByTournamentIdAsync(tournament.Id).GetAwaiter().GetResult();
            
            Console.WriteLine(tournament.Name);
            Console.WriteLine("========== Events =============");
            foreach (var eventObject in events)
            {
                var standings = smashggNetClient.EventEndpoint.GetEventStandings(eventObject.Id, 16, 1).GetAwaiter().GetResult();
            
                Console.WriteLine(eventObject.Name);
                foreach (var standing in standings)
                {
                    Console.WriteLine($"{standing.Placement}: {standing.Entrant.Name}");
                }
            }

        }
    }
}