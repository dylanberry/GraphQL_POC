using GraphQL.Types;
using GraphQL.Models.Entities;

namespace GraphQL.Models.Graph
{
    public class FieldType : ObjectGraphType<Field>
    {
        public FieldType()
        {
            Name = "Field";

            Field(x => x.Id).Description("The id of the field.");
            Field(x => x.Name).Description("The name of the field.");
            Field(x => x.Notes).Description("Notes for the field.");
        }
    }
}
