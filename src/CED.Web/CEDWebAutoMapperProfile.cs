using AutoMapper;
using CED.ClassInformations;

namespace CED.Web;

public class CEDWebAutoMapperProfile : Profile
{
    public CEDWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<SubjectDto, CreateUpdateSubjectDto>();
        CreateMap<ClassInformationDto, CreateUpdateClassInformationDto>();

    }
}
