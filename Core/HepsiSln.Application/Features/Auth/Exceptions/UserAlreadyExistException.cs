using HepsiSln.Application.Bases;

namespace HepsiSln.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistException : BaseExceptions
    {
        public UserAlreadyExistException() : base("Böyle bir kullanıcı zaten var") { }
    }
}
