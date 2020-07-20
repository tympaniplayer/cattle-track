using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace CattleTrack.Api.Cattle
{
  public class Create : BaseAsyncEndpoint<CreateCattleCommand, CreateCattleResult>
  {
    public override async Task<ActionResult<CreateCattleResult>> HandleAsync(CreateCattleCommand request)
    {
      throw new System.NotImplementedException();
    }
  }
}