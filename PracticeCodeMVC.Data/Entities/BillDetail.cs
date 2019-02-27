using PracticeCodeMVC.Infrastructure.SharedKenel;

namespace PracticeCodeMVC.Data.Entities
{
    public class BillDetail : DomainEntity<int>
    {
        public int BillID { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Bill Bill { get; set; }
    }
}