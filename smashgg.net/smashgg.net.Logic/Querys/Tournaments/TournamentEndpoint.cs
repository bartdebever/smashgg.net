using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;
using smashgg.net.Logic.Schemas;
using smashgg.net.Models.Events;
using smashgg.net.Models.Tournaments;

namespace smashgg.net.Logic.Querys.Tournaments
{
    public class TournamentEndpoint : GraphQlEndpoint, ITournamentEndpoint
    {
        public TournamentEndpoint(GraphQLClient graphQlClient) : base(graphQlClient)
        {
        }

        public Task<Tournament> GetByIdAsync(int id)
        {
            var queryString =
                "query TournamentQuery($id: ID!){tournament(id: $id){"+TournamentSchema.BasicTournamentSchema+"}}";

            var graphQlRequest = new GraphQLRequest
            {
                Query = queryString,
                Variables = new {id}
            };

            return ExecuteQueryAsync<Tournament>(graphQlRequest, "tournament");
        }

        public Task<Tournament> GetBySlugAsync(string slug)
        {

            var queryString  = "query TournamentQuery($slug: String) {tournament(slug: $slug){" + TournamentSchema.BasicTournamentSchema + "}}";

            var graphQlRequest = new GraphQLRequest
            {
                Query = queryString,
                Variables = new { slug }
            };

            return ExecuteQueryAsync<Tournament>(graphQlRequest, "tournament");
        }

        public async Task<List<Event>> GetEventsByTournamentIdAsync(int tournamentId)
        {
            var queryString = "query TournamentEvents($id: ID!){tournament(id: $id){\nevents{\n"+ EventSchema.BasicEventSchema+"}}}";

            var graphQlRequest = new GraphQLRequest
            {
                Query = queryString,
                Variables = new {id = tournamentId}
            };

            var tournament = await ExecuteQueryAsync<Tournament>(graphQlRequest, "tournament");
            return tournament.Events;
        }
    }
}