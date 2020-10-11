namespace QuickBuy.Domain.Entities
{
    public class Address : Entity
    {
        public int Id { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string AddressNumber { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(PostCode))
                AddValidation("Warning: Post Code cannot be empty");
            if (string.IsNullOrEmpty(State))
                AddValidation("Warning: Post Code cannot be empty");
            if (string.IsNullOrEmpty(City))
                AddValidation("Warning: Post Code cannot be empty");
            if (string.IsNullOrEmpty(Name))
                AddValidation("Warning: Post Code cannot be empty");
            if (string.IsNullOrEmpty(AddressNumber))
                AddValidation("Warning: Post Code cannot be empty");
        }
    }
}
