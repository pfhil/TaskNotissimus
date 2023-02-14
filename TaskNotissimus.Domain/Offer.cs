namespace TaskNotissimus.Domain
{
    public class Offer
    {
        public int Id { get; set; }

        public string? Url { get; set; }

        public int? Price { get; set; }

        public string? CurrencyId { get; set; }

        public CategoryId? CategoryId { get; set; }

        public string? Picture { get; set; }

        public bool? Delivery { get; set; }

        public int? LocalDeliveryCost { get; set; }

        public string? TypePrefix { get; set; }

        public string? Vendor { get; set; }

        public string? VendorCode { get; set; }

        public string? Model { get; set; }

        public string? Description { get; set; }

        public bool? ManufacturerWarranty { get; set; }

        public string? CountryOfOrigin { get; set; }

        public string? Type { get; set; }

        public int? Bid { get; set; }

        public int? Cbid { get; set; }

        public bool? Available { get; set; }

        public string? Text { get; set; }

        public string? Author { get; set; }

        public string? Name { get; set; }

        public string? Publisher { get; set; }

        public string? Series { get; set; }

        public int? Year { get; set; }

        public string? ISBN { get; set; }

        public int? Volume { get; set; }

        public int? Part { get; set; }

        public string? Language { get; set; }

        public string? Binding { get; set; }

        public int? PageExtent { get; set; }

        public bool? Downloadable { get; set; }

        public string? PerformedBy { get; set; }

        public string? PerformanceType { get; set; }

        public string? Storage { get; set; }

        public string? Format { get; set; }

        public string? RecordingLength { get; set; }

        public string? Artist { get; set; }

        public string? Title { get; set; }

        public string? Media { get; set; }

        public string? Starring { get; set; }

        public string? Director { get; set; }

        public string? OriginalName { get; set; }

        public string? Country { get; set; }

        public string? WorldRegion { get; set; }

        public string? Region { get; set; }

        public int? Days { get; set; }

        public List<DateTour>? DataTour { get; set; }

        public string? HotelStars { get; set; }

        public string? Room { get; set; }

        public string? Meal { get; set; }

        public string? Included { get; set; }

        public string? Transport { get; set; }

        public string? Place { get; set; }

        public Hall? Hall { get; set; }

        public string? HallPart { get; set; }

        public DateTime? Date { get; set; }

        public int? IsPremiere { get; set; }

        public int? IsKids { get; set; }
    }

    public class Hall
    {
        public int Id { get; set; }

        public string? Plan { get; set; }

        public string? Text { get; set; }
    }

    public class CategoryId
    {
        public int Id { get; set; }

        public string? Type { get; set; }

        public int? Text { get; set; }
    }

    public class DateTour
    {
        public int Id { get; set; }
        public DateTime Value { get; set; }
    }
}
