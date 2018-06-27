using System.Collections.Generic;

namespace GraphQL.Models.Entities
{
    public class FieldCropYear : TenantEntity
    {
        public string FieldId { get; set; }
        public decimal Area { get; set; }
        public string Boundary { get; set; }
        public Field Field { get; set; }
    }
}