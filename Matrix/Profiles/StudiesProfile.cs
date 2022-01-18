using AutoMapper;

namespace Matrix.Profiles
{
    public class StudiesProfile : Profile
    {
        public StudiesProfile()
        {
            CreateMap<Entities.Study, Models.StudyDto>();
            CreateMap<Models.StudyForCreationDto, Entities.Study>();
            CreateMap<Models.StudyForUpdateDto, Entities.Study>();
            CreateMap<Entities.Study, Models.StudyForUpdateDto>();
        }
    }
}
