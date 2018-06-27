using System.Collections.Generic;

namespace GraphQL.Models.Entities
{
    public class Field : TenantEntity
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public IList<FieldCropYear> FieldCropYears { get; set; } = new List<FieldCropYear>();
    }
}