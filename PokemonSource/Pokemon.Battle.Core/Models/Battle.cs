using System;
using System.Linq;

namespace Pokemon.Combat.Core.Models
{
    public class Battle
    {
        public Guid Id { get; }
        public Trainer Trainer1 { get; }
        public Trainer Trainer2 { get; }

        public Battle(Guid id, Trainer trainer1, Trainer trainer2)
        {
            Id = id;
            Trainer1 = trainer1;
            Trainer2 = trainer2;
        }

        public Monster GetMonster(Guid monsterId)
        {
            var monster = Trainer1.Party.FirstOrDefault(m => m.Id == monsterId);
            return monster ?? Trainer2.Party.First(m => m.Id == monsterId);
        }
    }
}