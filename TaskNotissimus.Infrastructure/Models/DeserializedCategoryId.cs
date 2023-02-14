using AutoMapper;
using System.Xml.Serialization;
using TaskNotissimus.Application.Common.Mapping;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Infrastructure.Models
{
    [XmlRoot(ElementName = "categoryId")]
    public class DeserializedCategoryId : IMapWith<CategoryId>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<DeserializedCategoryId, CategoryId>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text));
            profile.CreateMap<CategoryId, DeserializedCategoryId>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text));
        }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public int Text { get; set; }
    }
}
