using AutoMapper;
using CED.ClassInformations;
using CED.Subjects;
using CED.Web.Pages.ClassInformations;

namespace CED.Web;

public class CEDWebAutoMapperProfile : Profile
{
    public CEDWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<SubjectDto, CreateUpdateSubjectDto>();
        CreateMap<ClassInformationDto, CreateUpdateClassInformationDto>();

        CreateMap<CreateModalModel.CreateClassInformationViewModel, CreateUpdateClassInformationDto>();
        CreateMap<ClassInformationDto, EditModalModel.EditClassInformationViewModel>();
        CreateMap<EditModalModel.EditClassInformationViewModel, CreateUpdateClassInformationDto>();

    }
}
