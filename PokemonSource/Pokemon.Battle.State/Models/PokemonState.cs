using System;

namespace Pokemon.Combat.State.Models
{
    public class PokemonState
    {
        public Guid Id { get; set; }
        public int DataId { get; set; }
        public Guid TrainerId { get; set; }

        public TrainerState Trainer { get; set; }
    }
}