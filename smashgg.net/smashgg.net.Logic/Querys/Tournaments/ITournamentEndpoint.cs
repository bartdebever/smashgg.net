using System.Collections.Generic;
using System.Threading.Tasks;
using smashgg.net.Models.Events;
using smashgg.net.Models.Tournaments;

namespace smashgg.net.Logic.Querys.Tournaments
{
    public interface ITournamentEndpoint
    {
        Task<Tournament> GetByIdAsync(int id);
        
        Task<Tournament> GetBySlugAsync(string slug);

        Task<List<Event>> GetEventsByTournamentIdAsync(int tournamentId);
    }
}