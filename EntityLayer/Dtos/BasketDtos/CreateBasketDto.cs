namespace EntityLayer.Dtos.BasketDtos
{
    public class CreateBasketDto
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int MenuTableId { get; set; }
    }
}
