using System.Threading.Tasks;
using System.IdentityModel.Tokens;


namespace CattleTrack.Shared.Services
{
  public interface IGoogleTokenService
  {
    public Task<JwtSecurityToken> ValidateToken();
  }
}