using System;
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
        /// <inheritdoc />
        public TournamentEndpoint(GraphQLClient graphQlClient) : base(graphQlClient)
        {
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public Task<Tournament> GetBySlugAsync(string slug)
        {
            if (string.IsNullOrWhiteSpace(slug))
            {
                throw new ArgumentException($"{nameof(slug)} can not be null or empty.");
            }
            
            var queryString  = "query TournamentQuery($slug: String) {tournament(slug: $slug){" + TournamentSchema.BasicTournamentSchema + "}}";

            var graphQlRequest = new GraphQLRequest
            {
                Query = queryString,
                Variables = new { slug }
            };

            return ExecuteQueryAsync<Tournament>(graphQlRequest, "tournament");
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Event>> GetEventsByTournamentIdAsync(int tournamentId)
        {
            var queryString = "query TournamentEvents($id: ID!){tournament(id: $id){\nevents{\n"+ EventSchema.BasicEventSchema+"}}}";

            var graphQlRequest = new GraphQLRequest
            {
                Query = queryString,
                Variables = new {id = tournamentId}
            };

            var tournament = await ExecuteQueryAsync<Tournament>(graphQlRequest, "tournament");
            return tournament?.Events;
        }
    }
}