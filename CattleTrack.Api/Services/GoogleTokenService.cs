using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using CattleTrack.Shared.Services;

namespace CattleTrack.Api.Services
{
  public class GoogleTokenService : IGoogleTokenService
  {
    public async Task<JwtSecurityToken> ValidateToken(string token)
    {

    }
  }
}