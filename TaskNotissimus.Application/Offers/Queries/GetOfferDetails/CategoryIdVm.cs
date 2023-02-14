using AutoMapper;
using TaskNotissimus.Application.Common.Mapping;
using TaskNotissimus.Domain;

namespace TaskNotissimus.Application.Offers.Queries.GetOfferDetails
{
    public class CategoryIdVm : IMapWith<CategoryId>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CategoryIdVm, CategoryId>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text));
            profile.CreateMap<CategoryId, CategoryIdVm>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text));
        }

        public string Type { get; set; }

        public int Text { get; set; }
    }
}
