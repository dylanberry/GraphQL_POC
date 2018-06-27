using System;

namespace GraphQL.Models.Entities
{
    public class Tenant : UpdatedByEntity
    {
        public string Name { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
