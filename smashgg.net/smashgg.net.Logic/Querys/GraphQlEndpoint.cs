using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;

namespace smashgg.net.Logic.Querys
{
    public abstract class GraphQlEndpoint
    {
        protected GraphQLClient GraphQlClient;

        public GraphQlEndpoint(GraphQLClient graphQlClient)
        {
            GraphQlClient = graphQlClient;
        }

        protected async Task<TResult> ExecuteQueryAsync<TResult>(GraphQLRequest graphQlRequest, string nodeName)
            where TResult : class
        {
            var graphQlResponse = await GraphQlClient.PostAsync(graphQlRequest);
            if (graphQlResponse.Data == null)
            {
                return null;
            }

            return graphQlResponse.GetDataFieldAs<TResult>(nodeName);
        }
    }
}