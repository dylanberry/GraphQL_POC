namespace GraphQL.Models.Entities
{
    public abstract class UpdatedByEntity : TableEntity
    {
        public string UpdatedBy { get; set; }
        public User UpdatedByUser { get; set; }
    }
}