using System.Net.Http.Headers;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;
using GraphQL.Common.Response;
using smashgg.net.Logic.Querys.Events;
using smashgg.net.Logic.Querys.Tournaments;

namespace smashgg.net.Logic
{
    /// <summary>
    /// The class to execute smash.gg API requests.
    /// </summary>
    public class SmashggNetClient
    {
        private readonly GraphQLClient _graphQlClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SmashggNetClient"/> class. 
        /// </summary>
        /// <param name="token">The API token to use for doing requests.</param>
        /// <param name="uri">The uri smash.gg is using to send requests to.</param>
        public SmashggNetClient(string token, string uri = "https://api.smash.gg/gql/alpha")
        {
            _graphQlClient = new GraphQLClient(uri);
            _graphQlClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            _graphQlClient.DefaultRequestHeaders.Add("X-Source", "smashgg.net");
        }
        
        /// <summary>
        /// The endpoint to get tournament and tournament related entities.
        /// </summary>
        public ITournamentEndpoint TournamentEndpoint => new TournamentEndpoint(_graphQlClient);
        
        /// <summary>
        /// The endpoint to get event and event related entities.
        /// </summary>
        public IEventEndpoint EventEndpoint => new EventEndpoint(_graphQlClient);

        /// <summary>
        /// Creates and executes a custom request.
        /// </summary>
        /// <param name="request">The request to be executed.</param>
        /// <returns>The response gained from the smash.gg API.</returns>
        public Task<GraphQLResponse> ExecuteCustomRequest(GraphQLRequest request)
        {
            return _graphQlClient.PostAsync(request);
        }
    }
}