using AutoMapper;
using System.Xml.Serialization;
using TaskNotissimus.Application.Common.Mapping;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Infrastructure.Models
{
    [XmlRoot(ElementName = "hall")]
    public class DeserializedHall : IMapWith<Hall>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<DeserializedHall, Hall>()
                .ForMember(dest => dest.Plan, opt => opt.MapFrom(src => src.Plan));
            profile.CreateMap<Hall, DeserializedHall>()
                .ForMember(dest => dest.Plan, opt => opt.MapFrom(src => src.Plan));
        }

        [XmlAttribute(AttributeName = "plan")]
        public string Plan { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
