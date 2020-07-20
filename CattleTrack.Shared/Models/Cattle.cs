using System;
using NodaTime;
using NodaTime.Extensions;
using CattleTrack.Shared.Extensions;

namespace CattleTrack.Shared.Models
{
  public class Cattle
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Tag { get; set; }
    public LocalDate BirthDate { get; set; }
    public string Age
    {
      get
      {
        var clock = SystemClock.Instance.InUtc();
        Period age = Period.Between(BirthDate, clock.GetCurrentDate(), PeriodUnits.Years | PeriodUnits.Months | PeriodUnits.Days);
        return age.ToAgeString();
      }
    }
    //public CattleType Type { get; set; }
    public string Sex { get; }
    public string SexSubType { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
  }
}