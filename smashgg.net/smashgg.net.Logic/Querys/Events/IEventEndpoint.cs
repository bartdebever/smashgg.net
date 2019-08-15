using System.Collections.Generic;
using System.Threading.Tasks;
using smashgg.net.Models.Events;

namespace smashgg.net.Logic.Querys.Events
{
    public interface IEventEndpoint
    {
        Task<List<Standing>> GetEventStandings(int eventId, int pageCount, int page);
    }
}