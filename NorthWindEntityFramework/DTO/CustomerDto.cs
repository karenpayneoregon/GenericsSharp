namespace NorthWindEntityFramework
{
    public class CustomerDto
    {
        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public int? ContactId { get; set; }
        public int? CountryIdentifier { get; set; }
        public int? ContactTypeIdentifier { get; set; }
        public override string ToString() => CompanyName;
    }
}