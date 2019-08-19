using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;
using smashgg.net.Logic.Schemas;
using smashgg.net.Models.Events;
using smashgg.net.Models.Tournaments;
using smashgg.net.Querys.Querys;

namespace smashgg.net.Logic.Endpoints.Tournaments
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
            var graphQlRequest = new GraphQLRequest
            {
                Query = TournamentQuerys.GetTournamentById,
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

            var graphQlRequest = new GraphQLRequest
            {
                Query = TournamentQuerys.GetTournamentBySlug,
                Variables = new { slug }
            };

            return ExecuteQueryAsync<Tournament>(graphQlRequest, "tournament");
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Event>> GetEventsByTournamentIdAsync(int tournamentId)
        {
            var graphQlRequest = new GraphQLRequest
            {
                Query = TournamentQuerys.GetEventsByTournamentId,
                Variables = new {id = tournamentId}
            };

            var tournament = await ExecuteQueryAsync<Tournament>(graphQlRequest, "tournament");
            return tournament?.Events;
        }
    }
}