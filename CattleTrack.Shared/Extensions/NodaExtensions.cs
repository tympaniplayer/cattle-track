using System.Text;

using CattleTrack.Shared.Models;
using NodaTime;

namespace CattleTrack.Shared.Extensions
{
  public static class NodaExtensions
  {
    public static string ToAgeString(this Period period)
    {
      StringBuilder sb = new StringBuilder();

      if (period.Years > 0)
      {
        sb.Append(period.Years).Append(' ').Append(period.Years == 1 ? "Year " : "Years ");
      }
      if (period.Months > 0)
      {
        sb.Append(period.Months).Append(' ').Append(period.Months == 1 ? "Month " : "Months ");
      }
      if (period.Days > 0)
      {
        sb.Append(period.Days).Append(' ').Append(period.Days == 1 ? "Day " : "Days ");
      }
      return sb.ToString();
    }
  }
}