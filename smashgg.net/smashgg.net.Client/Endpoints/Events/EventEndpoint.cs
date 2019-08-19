using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;
using smashgg.net.Models.Events;
using smashgg.net.Querys.Querys;

namespace smashgg.net.Logic.Endpoints.Events
{
    public class EventEndpoint : GraphQlEndpoint, IEventEndpoint
    {
        public EventEndpoint(GraphQLClient graphQlClient) : base(graphQlClient)
        {
        }


        public async Task<IEnumerable<Standing>> GetEventStandings(int eventId, int pageCount, int page)
        {
            var graphQlRequest = new GraphQLRequest
            {
                Query = EventQuerys.GetStandingsForEvent,
                Variables = new {eventId, perPage = pageCount, page}
            };
            
            var eventObject = await ExecuteQueryAsync<Event>(graphQlRequest, "event");

            return eventObject?.Standings?.Nodes;
        }
    }
}