using System.Net.Http.Headers;
using GraphQL.Client;
using smashgg.net.Logic.Querys.Events;
using smashgg.net.Logic.Querys.Tournaments;

namespace smashgg.net.Logic
{
    public class SmashggNetClient
    {
        private GraphQLClient _graphQlClient;

        public SmashggNetClient(string token)
        {
            _graphQlClient = new GraphQLClient("https://api.smash.gg/gql/alpha");
            _graphQlClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            _graphQlClient.DefaultRequestHeaders.Add("X-Source", "smashgg.net");
        }
        
        public ITournamentEndpoint TournamentEndpoint => new TournamentEndpoint(_graphQlClient);
        
        public IEventEndpoint EventEndpoint => new EventEndpoint(_graphQlClient);
    }
}