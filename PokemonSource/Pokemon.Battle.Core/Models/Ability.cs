using System;

namespace Pokemon.Combat.Core.Models
{
    public class Ability
    {
        private int points;

        public Guid Id { get; }
        public int DataId { get; }
        public string Name { get; }

        public int Points
        {
            get => points;
            set => points = Math.Clamp(value, 0, 100);
        }

        public Ability(Guid id, int dataId, string name, int points)
        {
            Id = id;
            DataId = dataId;
            Name = name;
            this.points = points;
        }
    }
}