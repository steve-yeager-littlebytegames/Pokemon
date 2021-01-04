using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon.Combat.Core.Models
{
    public class Trainer
    {
        public Guid Id { get; }
        public string Name { get; }
        public IReadOnlyCollection<Monster> Party { get; }

        public bool HasAliveMonsters => Party.Any(m => m.Health > 0);

        public Trainer(Guid id, string name, IReadOnlyCollection<Monster> party)
        {
            Id = id;
            Name = name;
            Party = party;
        }
    }
}