namespace EntityLayer.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string FooterTitle { get; set; }
        public string FooterDescription { get; set; }
        public string OpenDays{ get; set; }
        public string OpenDayDescription{ get; set; }
        public string OpenHours{ get; set; }
    }
}
