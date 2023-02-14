using AutoMapper;
using System.Xml.Serialization;
using TaskNotissimus.Application.Common.Mapping;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Infrastructure.Models
{
    [XmlRoot(ElementName = "offer")]
    public class DeserializedOffer : IMapWith<Offer>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<List<DateTour>?, List<DateTime>?>().ConvertUsing(converted =>
                    converted != null && converted.Any()
                        ? new List<DateTime>(converted.Select(dataTour => dataTour.Value).ToList())
                        : null);
            profile.CreateMap<List<DateTime>?, List<DateTour>?>().ConvertUsing(converted =>
                    converted != null
                        ? new List<DateTour>(converted.Select(dateTime => new DateTour()
                        {
                            Value = dateTime
                        }).ToList())
                        : null);

            profile.CreateMap<Offer, DeserializedOffer>()
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

            profile.CreateMap<DeserializedOffer, Offer>()
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

        [XmlElement(ElementName = "url")]
        public string? Url { get; set; }

        [XmlElement(ElementName = "price")]
        public int? Price { get; set; }

        [XmlElement(ElementName = "currencyId")]
        public string? CurrencyId { get; set; }

        [XmlElement(ElementName = "categoryId")]
        public DeserializedCategoryId? CategoryId { get; set; }

        [XmlElement(ElementName = "picture")]
        public string? Picture { get; set; }

        [XmlElement(ElementName = "delivery")]
        public bool? Delivery { get; set; }

        [XmlElement(ElementName = "local_delivery_cost")]
        public int? LocalDeliveryCost { get; set; }

        [XmlElement(ElementName = "typePrefix")]
        public string? TypePrefix { get; set; }

        [XmlElement(ElementName = "vendor")]
        public string? Vendor { get; set; }

        [XmlElement(ElementName = "vendorCode")]
        public string? VendorCode { get; set; }

        [XmlElement(ElementName = "model")]
        public string? Model { get; set; }

        [XmlElement(ElementName = "description")]
        public string? Description { get; set; }

        [XmlElement(ElementName = "manufacturer_warranty")]
        public bool? ManufacturerWarranty { get; set; }

        [XmlElement(ElementName = "country_of_origin")]
        public string? CountryOfOrigin { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "bid")]
        public int Bid { get; set; }

        [XmlAttribute(AttributeName = "cbid")]
        public string _Cbid
        {
            get
            {
                return Cbid.HasValue ? Cbid.Value.ToString() : string.Empty;
            }
            set
            {
                Cbid = !string.IsNullOrEmpty(value) ? int.Parse(value) : null;
            }
        }

        [XmlIgnore]
        public int? Cbid { get; set; }

        [XmlAttribute(AttributeName = "available")]
        public bool Available { get; set; }

        [XmlText]
        public string? Text { get; set; }

        [XmlElement(ElementName = "author")]
        public string? Author { get; set; }

        [XmlElement(ElementName = "name")]
        public string? Name { get; set; }

        [XmlElement(ElementName = "publisher")]
        public string? Publisher { get; set; }

        [XmlElement(ElementName = "series")]
        public string? Series { get; set; }

        [XmlElement(ElementName = "year")]
        public int? Year { get; set; }

        [XmlElement(ElementName = "ISBN")]
        public string? ISBN { get; set; }

        [XmlElement(ElementName = "volume")]
        public int? Volume { get; set; }

        [XmlElement(ElementName = "part")]
        public int? Part { get; set; }

        [XmlElement(ElementName = "language")]
        public string? Language { get; set; }

        [XmlElement(ElementName = "binding")]
        public string? Binding { get; set; }

        [XmlElement(ElementName = "page_extent")]
        public int? PageExtent { get; set; }

        [XmlElement(ElementName = "downloadable")]
        public bool? Downloadable { get; set; }

        [XmlElement(ElementName = "performed_by")]
        public string? PerformedBy { get; set; }

        [XmlElement(ElementName = "performance_type")]
        public string? PerformanceType { get; set; }

        [XmlElement(ElementName = "storage")]
        public string? Storage { get; set; }

        [XmlElement(ElementName = "format")]
        public string? Format { get; set; }

        [XmlElement(ElementName = "recording_length")]
        public string? RecordingLength { get; set; }

        [XmlElement(ElementName = "artist")]
        public string? Artist { get; set; }

        [XmlElement(ElementName = "title")]
        public string? Title { get; set; }

        [XmlElement(ElementName = "media")]
        public string? Media { get; set; }

        [XmlElement(ElementName = "starring")]
        public string? Starring { get; set; }

        [XmlElement(ElementName = "director")]
        public string? Director { get; set; }

        [XmlElement(ElementName = "originalName")]
        public string? OriginalName { get; set; }

        [XmlElement(ElementName = "country")]
        public string? Country { get; set; }

        [XmlElement(ElementName = "worldRegion")]
        public string? WorldRegion { get; set; }

        [XmlElement(ElementName = "region")]
        public string? Region { get; set; }

        [XmlElement(ElementName = "days")]
        public int? Days { get; set; }

        [XmlElement(ElementName = "dataTour")]
        public List<string>? _DataTour { get; set; }

        [XmlIgnore]
        public List<DateTime>? DataTour
        {
            get => _DataTour.Select(d => DateTime.Parse(d)).ToList();
            set => _DataTour = value.Select(date => date.ToString()).ToList();
        }

        [XmlElement(ElementName = "hotel_stars")]
        public string? HotelStars { get; set; }

        [XmlElement(ElementName = "room")]
        public string? Room { get; set; }

        [XmlElement(ElementName = "meal")]
        public string? Meal { get; set; }

        [XmlElement(ElementName = "included")]
        public string? Included { get; set; }

        [XmlElement(ElementName = "transport")]
        public string? Transport { get; set; }

        [XmlElement(ElementName = "place")]
        public string? Place { get; set; }

        [XmlElement(ElementName = "hall")]
        public DeserializedHall? Hall { get; set; }

        [XmlElement(ElementName = "hall_part")]
        public string? HallPart { get; set; }

        [XmlElement(ElementName = "date")]
        public string? _Date { get; set; }

        [XmlIgnore]
        public DateTime? Date
        {
            get => string.IsNullOrWhiteSpace(_Date)
                ? null
                : DateTime.Parse(_Date);
            set => _Date = value?.ToString();
        }

        [XmlElement(ElementName = "is_premiere")]
        public int? IsPremiere { get; set; }

        [XmlElement(ElementName = "is_kids")]
        public int? IsKids { get; set; }
    }
}
