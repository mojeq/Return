using System;


namespace Return.Models.Services
{
    public class DateTimeNow : IDateTimeNow
    {
        public DateTime dateTime { get; set; }
        public DateTimeNow()
        {
            dateTime = DateTime.Now;
        }
    }
}
