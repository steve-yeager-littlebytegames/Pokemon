using System;

namespace Pokemon.Combat.State.Models
{
    public class BattleState
    {
        public Guid Id { get; set; }
        public int TurnNumber { get; set; }
        public TrainerState Trainer1 { get; set; }
        public TrainerState Trainer2 { get; set; }
    }
}