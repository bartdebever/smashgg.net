using System.Collections.Generic;
using System.Threading.Tasks;
using smashgg.net.Models.Events;

namespace smashgg.net.Logic.Querys.Events
{
    public interface IEventEndpoint
    {
        /// <summary>
        /// Gets a list of standings based on the provided <paramref name="eventId"/>.
        /// </summary>
        /// <param name="eventId">The event wanting the standings from.</param>
        /// <param name="pageCount">The amount of items per page to be displayed.</param>
        /// <param name="page">
        /// The page to start from.
        /// PAGE NUMBERS START FROM 1.
        /// </param>
        /// <returns>A list of standings found or null.</returns>
        Task<IEnumerable<Standing>> GetEventStandings(int eventId, int pageCount, int page);
    }
}