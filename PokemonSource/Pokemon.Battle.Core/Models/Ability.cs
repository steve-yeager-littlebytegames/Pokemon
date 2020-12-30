using System;

namespace Pokemon.Combat.Core.Models
{
    public class Ability
    {
        private int points;

        public int DataId { get; }
        public string Name { get; }

        public int Points
        {
            get => points;
            set => points = Math.Clamp(value, 0, 100);
        }

        public Ability(int dataId, string name, int points)
        {
            DataId = dataId;
            Name = name;
            this.points = points;
        }
    }
}