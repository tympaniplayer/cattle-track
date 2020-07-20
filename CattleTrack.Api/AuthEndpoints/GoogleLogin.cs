using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Google.Apis.Auth;

namespace CattleTrack.Api.Google
{
  public class GoogleLogin : BaseAsyncEndpoint<LoginCommand, LoginResult>
  {
    public override Task<ActionResult<LoginResult>> HandleAsync(LoginCommand request)
    {

      throw new System.NotImplementedException();
    }
  }
}