﻿namespace webapi.Models
{
    public class BookDTO
    {
        public string? AaName { get; set; }
        public string? Author { get; set; }
        public string? Series { get; set; }
        public bool? OwnedOrWish { get; set; }
        public Status? Status { get; set; }
        public Score? Score { get; set; }
        public string? Comment { get; set; }
        public virtual List<Trope>? Tropes { get; set; } = new();
        public virtual List<Genre>? Genres { get; set; } = new();
    }
}
