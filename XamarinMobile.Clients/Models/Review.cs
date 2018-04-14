using System;

namespace XamarinMobile.Clients.Models
{
    public class Review
    {
        public int HotelId { get; set; }
        public string User { get; set; }
        public string Room { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int Raiting { get; set; }
    }
}
