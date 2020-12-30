using System;

namespace Pokemon.Combat.State.Models
{
    public class BattleMetadata
    {
        public Guid Id { get; set; }
        public int Turn { get; set; }
        // TODO: Move Requests
    }
}