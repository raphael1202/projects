using QuickBuy.Domain.Enum;

namespace QuickBuy.Domain.ValueObject
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsBill
        {
            get { return Id == (int)PaymentTypeEnum.Bill; }
        }

        public bool IsCreditCard
        {
            get { return Id == (int)PaymentTypeEnum.Bill; }
        }

        public bool IsDeposit
        {
            get { return Id == (int)PaymentTypeEnum.Deposit; }
        }
    }
}
