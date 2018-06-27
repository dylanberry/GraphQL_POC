using System.Security.Claims;

namespace GraphQL.Server
{
    public class GraphQLUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}
