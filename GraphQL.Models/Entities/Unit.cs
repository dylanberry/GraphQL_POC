namespace GraphQL.Models.Entities
{
    public class Unit : TenantEntity
    {
        public string NameEnglish { get; set; }
        public string NameFrench { get; set; }
        public string AbbreviationEnglish { get; set; }
        public string AbbreviationFrench { get; set; }
        public decimal? ConversionFactor { get; set; }
        public string ConversionUnitId { get; set; }
        public Unit ConversionUnit { get; set; }
    }
}
