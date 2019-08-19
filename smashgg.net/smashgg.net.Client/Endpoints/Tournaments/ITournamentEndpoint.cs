using System.Collections.Generic;
using System.Threading.Tasks;
using smashgg.net.Models.Events;
using smashgg.net.Models.Tournaments;

namespace smashgg.net.Logic.Endpoints.Tournaments
{
    public interface ITournamentEndpoint
    {
        /// <summary>
        /// Gets the tournament object based on the provided <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The id of the tournament to be found.</param>
        /// <returns>The tournament object found or null.</returns>
        Task<Tournament> GetByIdAsync(int id);
        
        /// <summary>
        /// Gets the tournament object for the provided <paramref name="slug"/>.
        /// Slugs do not contain spaces and are rather found in the URL to the tournament.
        /// <para>
        /// Example:
        /// https://smash.gg/tournament/super-smash-con-2019 It's slug is super-smash-con-2019.
        /// </para>
        /// </summary>
        /// <param name="slug">The slug of the tournament to be found.</param>
        /// <returns>The tournament object found or null.</returns>
        Task<Tournament> GetBySlugAsync(string slug);

        /// <summary>
        /// Gets a list of <see cref="Event"/> objects based on the <paramref name="tournamentId"/>.
        /// </summary>
        /// <param name="tournamentId">The id of the <see cref="Tournament"/> object to look for.</param>
        /// <returns>A collection of <see cref="Event"/> objects.</returns>
        Task<IEnumerable<Event>> GetEventsByTournamentIdAsync(int tournamentId);
    }
}