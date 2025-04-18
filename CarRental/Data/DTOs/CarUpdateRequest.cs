﻿namespace CarRental.Data.DTOs
{
    public class CarUpdateRequest
    {
        public int Id { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public decimal DailyRate { get; set; }
        public string Location { get; set; } = null!;
        public bool IsAvailable { get; set; }
        public string? LicensePlate { get; set; }
        public IFormFileCollection? Images { get; set; }
    }

}
