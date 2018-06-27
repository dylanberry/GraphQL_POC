namespace GraphQL.Models.Entities
{
    public class Person : TenantEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsCustomer { get; set; }
        public string Notes { get; set; }
    }
}