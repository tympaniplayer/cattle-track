using System;

namespace CattleTrack.Shared.Models
{
  public class Record
  {
    public int Id { get; set; }
    public DateTime RecordDate { get; set; }
    public int CattleId { get; set; }
    public Cattle Cattle { get; set; }
  }
}