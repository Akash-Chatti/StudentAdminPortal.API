using AutoMapper;


namespace StudenAdminPortal.API.Profiles
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<DataModels.Student, DomainModels.Student>().ReverseMap();
            CreateMap<DataModels.Gender, DomainModels.Gender>().ReverseMap();
            CreateMap<DataModels.Address, DomainModels.Address>().ReverseMap();
        }
    }
}
