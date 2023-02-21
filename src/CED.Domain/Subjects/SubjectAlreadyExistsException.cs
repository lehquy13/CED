using Volo.Abp;
namespace CED.Subjects
{
    public class SubjectAlreadyExistsException : BusinessException
    {
        public SubjectAlreadyExistsException(string name)
        : base(CEDDomainErrorCodes.SubjectAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
