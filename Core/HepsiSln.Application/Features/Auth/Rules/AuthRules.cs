using HepsiSln.Application.Bases;
using HepsiSln.Application.Features.Auth.Exceptions;
using HepsiSln.Domain.Entities;

namespace HepsiSln.Application.Features.Auth.Rules
{
    public class AuthRules:BaseRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user is not null) throw new UserAlreadyExistException();
            return Task.CompletedTask;
        }
    }
}
