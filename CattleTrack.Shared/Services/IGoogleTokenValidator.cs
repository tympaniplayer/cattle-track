using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;

namespace CattleTrack.Shared.Services
{
  public interface IGoogleTokenService
  {
    Task<JwtSecurityToken> ValidateToken(string AccessToken);
  }
}