using System;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;

namespace smashgg.net.Logic.Endpoints
{
    public abstract class GraphQlEndpoint
    {
        protected GraphQLClient GraphQlClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQlEndpoint"/> object.
        /// </summary>
        /// <param name="graphQlClient">The <see cref="GraphQLClient"/> to execute requests with.</param>
        // ReSharper disable once PublicConstructorInAbstractClass
        // I want this constructor to be public to force the implementations to use it.
        public GraphQlEndpoint(GraphQLClient graphQlClient)
        {
            GraphQlClient = graphQlClient;
        }

        /// <summary>
        /// Executes the provided <paramref name="graphQlRequest"/> and converts the results to the correct type.
        /// </summary>
        /// <param name="graphQlRequest">The request object to sent to the API.</param>
        /// <param name="nodeName">The name of the node to be converted for the result.</param>
        /// <typeparam name="TResult">The type of the result wanting to be gotten.</typeparam>
        /// <returns>The acquired result or null. </returns>
        /// <exception cref="ArgumentException">When the <paramref name="nodeName"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">When the <paramref name="graphQlRequest"/> is null.</exception>
        protected async Task<TResult> ExecuteQueryAsync<TResult>(GraphQLRequest graphQlRequest, string nodeName)
            where TResult : class
        {
            if (string.IsNullOrWhiteSpace(nodeName))
            {
                throw new ArgumentException($"{nameof(nodeName)} may not be null or empty.");
            }

            if (graphQlRequest == null)
            {
                throw new ArgumentNullException($"{nameof(graphQlRequest)} may not be null.");
            }
            
            var graphQlResponse = await GraphQlClient.PostAsync(graphQlRequest);
            return graphQlResponse?.GetDataFieldAs<TResult>(nodeName);
        }
    }
}