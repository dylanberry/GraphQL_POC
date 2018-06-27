using System;
using GraphQL.Models.Interfaces;

namespace GraphQL.Models.Entities
{
    public abstract class TableEntity : ITableEntity
    {
        public string Id { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public bool Deleted { get; set; }
        public byte[] Version { get; set; }
    }
}