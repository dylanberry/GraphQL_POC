using System;
using GraphQL.Models.Graph.MockData;
using GraphQL.Types;

namespace GraphQL.Models.Graph
{
    public class FieldQuery : ObjectGraphType<object>
    {
        public FieldQuery(FieldData data)
        {
            Name = "Query";

            Field<ListGraphType<FieldType>>("fieldList", resolve: context => data.GetFieldsAsync());

            Func<ResolveFieldContext, string, object> func = (context, id) => data.GetFieldByIdAsync(id);

            FieldDelegate<FieldType>(
                "field",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "id of the Field" }
                ),
                resolve: func
            );
        }
    }
}
