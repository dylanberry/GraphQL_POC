using GraphQL;
using GraphQL.Types;

namespace GraphQL.Models.Graph
{
    public class FieldSchema : Schema
    {
        public FieldSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<FieldQuery>();
        }
    }
}
