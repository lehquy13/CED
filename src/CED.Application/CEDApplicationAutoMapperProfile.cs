using AutoMapper;
using CED.ClassInformations;
using CED.Subjects;

namespace CED;

public class CEDApplicationAutoMapperProfile : Profile
{
    public CEDApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Subject, SubjectDto>();
        CreateMap<CreateUpdateSubjectDto, Subject>();
        CreateMap<Subject, SubjectLookupDto>();

        CreateMap<AvailableDate, AvailableDateDto>();
        CreateMap<CreateUpdateAvailableDateDto, AvailableDate>();

        CreateMap<ClassInformation, ClassInformationDto>();
        CreateMap<CreateUpdateClassInformationDto, ClassInformation>();
       
    }
}
