using AutoMapper;
using TaskNotissimus.Application.Common.Mapping;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Application.Offers.Queries.GetOfferDetails
{
    public class OfferVm : IMapWith<Offer>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Offer, OfferVm>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Picture, opt => opt.MapFrom(src => src.Picture))
                .ForMember(dest => dest.Delivery, opt => opt.MapFrom(src => src.Delivery))
                .ForMember(dest => dest.LocalDeliveryCost, opt => opt.MapFrom(src => src.LocalDeliveryCost))
                .ForMember(dest => dest.TypePrefix, opt => opt.MapFrom(src => src.TypePrefix))
                .ForMember(dest => dest.Vendor, opt => opt.MapFrom(src => src.Vendor))
                .ForMember(dest => dest.VendorCode, opt => opt.MapFrom(src => src.VendorCode))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ManufacturerWarranty, opt => opt.MapFrom(src => src.ManufacturerWarranty))
                .ForMember(dest => dest.CountryOfOrigin, opt => opt.MapFrom(src => src.CountryOfOrigin))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Bid, opt => opt.MapFrom(src => src.Bid))
                .ForMember(dest => dest.Cbid, opt => opt.MapFrom(src => src.Cbid))
                .ForMember(dest => dest.Available, opt => opt.MapFrom(src => src.Available))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Publisher, opt => opt.MapFrom(src => src.Publisher))
                .ForMember(dest => dest.Series, opt => opt.MapFrom(src => src.Series))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.ISBN, opt => opt.MapFrom(src => src.ISBN))
                .ForMember(dest => dest.Volume, opt => opt.MapFrom(src => src.Volume))
                .ForMember(dest => dest.Part, opt => opt.MapFrom(src => src.Part))
                .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language))
                .ForMember(dest => dest.Binding, opt => opt.MapFrom(src => src.Binding))
                .ForMember(dest => dest.PageExtent, opt => opt.MapFrom(src => src.PageExtent))
                .ForMember(dest => dest.Downloadable, opt => opt.MapFrom(src => src.Downloadable))
                .ForMember(dest => dest.PerformedBy, opt => opt.MapFrom(src => src.PerformedBy))
                .ForMember(dest => dest.PerformanceType, opt => opt.MapFrom(src => src.PerformanceType))
                .ForMember(dest => dest.Storage, opt => opt.MapFrom(src => src.Storage))
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))
                .ForMember(dest => dest.RecordingLength, opt => opt.MapFrom(src => src.RecordingLength))
                .ForMember(dest => dest.Artist, opt => opt.MapFrom(src => src.Artist))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Media, opt => opt.MapFrom(src => src.Media))
                .ForMember(dest => dest.Starring, opt => opt.MapFrom(src => src.Starring))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director))
                .ForMember(dest => dest.OriginalName, opt => opt.MapFrom(src => src.OriginalName))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
                .ForMember(dest => dest.WorldRegion, opt => opt.MapFrom(src => src.WorldRegion))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Region))
                .ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.Days))
                .ForMember(dest => dest.DataTour, opt => opt.MapFrom(src => src.DataTour))
                .ForMember(dest => dest.HotelStars, opt => opt.MapFrom(src => src.HotelStars))
                .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.Room))
                .ForMember(dest => dest.Meal, opt => opt.MapFrom(src => src.Meal))
                .ForMember(dest => dest.Included, opt => opt.MapFrom(src => src.Included))
                .ForMember(dest => dest.Transport, opt => opt.MapFrom(src => src.Transport))
                .ForMember(dest => dest.Place, opt => opt.MapFrom(src => src.Place))
                .ForMember(dest => dest.Hall, opt => opt.MapFrom(src => src.Hall))
                .ForMember(dest => dest.HallPart, opt => opt.MapFrom(src => src.HallPart))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.IsPremiere, opt => opt.MapFrom(src => src.IsPremiere))
                .ForMember(dest => dest.IsKids, opt => opt.MapFrom(src => src.IsKids));

            profile.CreateMap<OfferVm, Offer>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Picture, opt => opt.MapFrom(src => src.Picture))
                .ForMember(dest => dest.Delivery, opt => opt.MapFrom(src => src.Delivery))
                .ForMember(dest => dest.LocalDeliveryCost, opt => opt.MapFrom(src => src.LocalDeliveryCost))
                .ForMember(dest => dest.TypePrefix, opt => opt.MapFrom(src => src.TypePrefix))
                .ForMember(dest => dest.Vendor, opt => opt.MapFrom(src => src.Vendor))
                .ForMember(dest => dest.VendorCode, opt => opt.MapFrom(src => src.VendorCode))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ManufacturerWarranty, opt => opt.MapFrom(src => src.ManufacturerWarranty))
                .ForMember(dest => dest.CountryOfOrigin, opt => opt.MapFrom(src => src.CountryOfOrigin))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Bid, opt => opt.MapFrom(src => src.Bid))
                .ForMember(dest => dest.Cbid, opt => opt.MapFrom(src => src.Cbid))
                .ForMember(dest => dest.Available, opt => opt.MapFrom(src => src.Available))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Publisher, opt => opt.MapFrom(src => src.Publisher))
                .ForMember(dest => dest.Series, opt => opt.MapFrom(src => src.Series))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.ISBN, opt => opt.MapFrom(src => src.ISBN))
                .ForMember(dest => dest.Volume, opt => opt.MapFrom(src => src.Volume))
                .ForMember(dest => dest.Part, opt => opt.MapFrom(src => src.Part))
                .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language))
                .ForMember(dest => dest.Binding, opt => opt.MapFrom(src => src.Binding))
                .ForMember(dest => dest.PageExtent, opt => opt.MapFrom(src => src.PageExtent))
                .ForMember(dest => dest.Downloadable, opt => opt.MapFrom(src => src.Downloadable))
                .ForMember(dest => dest.PerformedBy, opt => opt.MapFrom(src => src.PerformedBy))
                .ForMember(dest => dest.PerformanceType, opt => opt.MapFrom(src => src.PerformanceType))
                .ForMember(dest => dest.Storage, opt => opt.MapFrom(src => src.Storage))
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.Format))
                .ForMember(dest => dest.RecordingLength, opt => opt.MapFrom(src => src.RecordingLength))
                .ForMember(dest => dest.Artist, opt => opt.MapFrom(src => src.Artist))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Media, opt => opt.MapFrom(src => src.Media))
                .ForMember(dest => dest.Starring, opt => opt.MapFrom(src => src.Starring))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director))
                .ForMember(dest => dest.OriginalName, opt => opt.MapFrom(src => src.OriginalName))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
                .ForMember(dest => dest.WorldRegion, opt => opt.MapFrom(src => src.WorldRegion))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Region))
                .ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.Days))
                .ForMember(dest => dest.DataTour, opt => opt.MapFrom(src => src.DataTour))
                .ForMember(dest => dest.HotelStars, opt => opt.MapFrom(src => src.HotelStars))
                .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.Room))
                .ForMember(dest => dest.Meal, opt => opt.MapFrom(src => src.Meal))
                .ForMember(dest => dest.Included, opt => opt.MapFrom(src => src.Included))
                .ForMember(dest => dest.Transport, opt => opt.MapFrom(src => src.Transport))
                .ForMember(dest => dest.Place, opt => opt.MapFrom(src => src.Place))
                .ForMember(dest => dest.Hall, opt => opt.MapFrom(src => src.Hall))
                .ForMember(dest => dest.HallPart, opt => opt.MapFrom(src => src.HallPart))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.IsPremiere, opt => opt.MapFrom(src => src.IsPremiere))
                .ForMember(dest => dest.IsKids, opt => opt.MapFrom(src => src.IsKids));
        }

        public string? Url { get; set; }

        public int? Price { get; set; }

        public string? CurrencyId { get; set; }

        public CategoryIdVm? CategoryId { get; set; }

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

        public int Id { get; set; }

        public string Type { get; set; }

        public int Bid { get; set; }

        public int? Cbid { get; set; }

        public bool Available { get; set; }

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

        public List<DateTime>? DataTour { get; set; }

        public string? HotelStars { get; set; }

        public string? Room { get; set; }

        public string? Meal { get; set; }

        public string? Included { get; set; }

        public string? Transport { get; set; }

        public string? Place { get; set; }

        public HallVm? Hall { get; set; }

        public string? HallPart { get; set; }

        public DateTime? Date { get; set; }

        public int? IsPremiere { get; set; }

        public int? IsKids { get; set; }
    }
}
