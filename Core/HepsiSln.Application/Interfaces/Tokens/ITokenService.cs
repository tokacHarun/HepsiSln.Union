using HepsiSln.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace HepsiSln.Application.Interfaces.Tokens
{
    public interface ITokenService
    {
        Task<JwtSecurityToken> CreateToken(User user, IList<String> roles);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincibalFromExpiredToken(string? token);
    }
}
