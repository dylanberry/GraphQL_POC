using System;

namespace GraphQL.Models.Entities
{
    public class User : TableEntity
    {
        public string PersonId { get; set; }
        public Guid ActiveDirectoryObjectId { get; set; }
        public Person Person { get; set; }
    }
}