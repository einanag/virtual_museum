using System;

namespace virtual_museum_f
{
    public class EventItem
    {
        public DateTime FromDate { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"{FromDate:dd/MM/yyyy} - {Description}";
        }

    }
}
