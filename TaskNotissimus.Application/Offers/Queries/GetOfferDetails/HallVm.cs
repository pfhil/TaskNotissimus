using AutoMapper;
using TaskNotissimus.Application.Common.Mapping;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Application.Offers.Queries.GetOfferDetails
{
    public class HallVm : IMapWith<Hall>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<HallVm, Hall>()
                .ForMember(dest => dest.Plan, opt => opt.MapFrom(src => src.Plan));
            profile.CreateMap<Hall, HallVm>()
                .ForMember(dest => dest.Plan, opt => opt.MapFrom(src => src.Plan));
        }

        public string Plan { get; set; }

        public string Text { get; set; }
    }
}
