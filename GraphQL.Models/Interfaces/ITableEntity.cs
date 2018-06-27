using System;

namespace GraphQL.Models.Interfaces
{
    public interface ITableEntity
    {
        string Id { get; set; }

        byte[] Version { get; set; }

        DateTimeOffset? CreatedAt { get; set; }

        DateTimeOffset? UpdatedAt { get; set; }

        bool Deleted { get; set; }
    }
}
