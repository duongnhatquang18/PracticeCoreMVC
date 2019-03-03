using PracticeCodeMVC.Infrastructure.SharedKenel;

namespace PracticeCodeMVC.Data.Entities
{
    public class BillDetail : DomainEntity<int>
    {
        public BillDetail() { }

        public BillDetail(int id, int billId, int productId, int quantity, decimal price, int colorId, int sizeId)
        {
            Id = id;
            BillID = billId;
            ProductID = productId;
            Quantity = quantity;
            Price = price;
            ColorId = colorId;
            SizeId = sizeId;
        }

        public BillDetail(int billId, int productId, int quantity, decimal price, int colorId, int sizeId)
        {
            BillID = billId;
            ProductID = productId;
            Quantity = quantity;
            Price = price;
            ColorId = colorId;
            SizeId = sizeId;
        }

        public int BillID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Product Product { set; get; }
        public virtual Color Color { set; get; }
        public virtual Size Size { set; get; }
    }
}