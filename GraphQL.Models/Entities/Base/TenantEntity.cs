namespace GraphQL.Models.Entities
{
    public abstract class TenantEntity : UpdatedByEntity 
    {
        public string TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}