namespace EntityLayer.Dtos.BasketDtos
{
    public class ResultBasketDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public string MenuTableName{ get; set; }

    }
}
