using System;

namespace Pokemon.State.Models
{
    public class AbilityState
    {
        public Guid Id { get; set; }
        public int AbilityId { get; set; }
        public int Points { get; set; }
    }
}