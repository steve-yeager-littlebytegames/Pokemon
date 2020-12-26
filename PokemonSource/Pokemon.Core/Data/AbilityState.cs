using System;

namespace Pokemon.Core.Data
{
    public class AbilityState
    {
        public Guid Id { get; set; }
        public Guid AbilityId { get; set; }
        public int Points { get; set; }
    }
}