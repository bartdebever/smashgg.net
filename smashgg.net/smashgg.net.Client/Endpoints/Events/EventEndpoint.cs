using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;
using smashgg.net.Models.Events;

namespace smashgg.net.Logic.Endpoints.Events
{
    public class EventEndpoint : GraphQlEndpoint, IEventEndpoint
    {
        public EventEndpoint(GraphQLClient graphQlClient) : base(graphQlClient)
        {
        }


        public async Task<IEnumerable<Standing>> GetEventStandings(int eventId, int pageCount, int page)
        {
            var queryString =
                "query EventStandings($eventId: ID!, $page: Int!, $perPage: Int!) {\n  event(id: $eventId) {\name\nstandings(query:{\nperPage: $perPage,\npage: $page\n}){\nnodes {\nstanding\nentrant{\nname}}}}}";

            var graphQlRequest = new GraphQLRequest
            {
                Query = queryString,
                Variables = new {eventId, perPage = pageCount, page}
            };
            
            var eventObject = await ExecuteQueryAsync<Event>(graphQlRequest, "event");

            return eventObject?.Standings?.Nodes;
        }
    }
}