using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon.Combat.Core.Models
{
    public class Monster
    {
        private int health;

        public Guid Id { get; }
        public int DataId { get; }
        public string Name { get; }
        public int Health
        {
            get => health;
            // TODO: Use max health.
            set => health = Math.Clamp(value, 0, 100);
        }

        public IReadOnlyCollection<Ability> Abilities { get; }

        public Monster(Guid id, int dataId, string name, int health, IReadOnlyCollection<Ability> abilities)
        {
            Id = id;
            DataId = dataId;
            Name = name;
            this.health = health;
            Abilities = abilities;
        }

        public Ability GetAbility(Guid abilityId) => Abilities.First(a => a.Id == abilityId);
    }
}