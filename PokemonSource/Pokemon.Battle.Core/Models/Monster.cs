using System;
using System.Collections.Generic;

namespace Pokemon.Combat.Core.Models
{
    public class Monster
    {
        public Guid Id { get; }
        public int DataId { get; }
        public string Name { get; }
        public int Health { get; }

        public IReadOnlyCollection<Ability> Abilities { get; }

        public Monster(Guid id, int dataId, string name, int health, IReadOnlyCollection<Ability> abilities)
        {
            Id = id;
            DataId = dataId;
            Name = name;
            Health = health;
            Abilities = abilities;
        }
    }
}