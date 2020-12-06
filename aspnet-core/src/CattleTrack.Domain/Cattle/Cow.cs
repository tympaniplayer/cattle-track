using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace CattleTrack.Cattle
{
    public class Cow : AuditedAggregateRoot<Guid>
    {
        public string Name { get; protected set; }
        public string Tag { get; protected set; }
        public DateTime Birthdate { get; protected set; }
        public CowBreed Breed { get; protected set; }
        public CowType Type { get; protected set; }
    }
}