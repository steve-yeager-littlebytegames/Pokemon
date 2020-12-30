using System;
using System.Collections.Generic;

namespace Pokemon.Combat.Core.Models
{
    public class Trainer
    {
        public Guid Id { get; }
        public string Name { get; }
        public IReadOnlyCollection<Monster> Party { get; }

        public Trainer(Guid id, string name, IReadOnlyCollection<Monster> party)
        {
            Id = id;
            Name = name;
            Party = party;
        }
    }
}