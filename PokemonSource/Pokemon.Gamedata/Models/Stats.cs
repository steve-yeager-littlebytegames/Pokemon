using System;

namespace Pokemon.Gamedata.Models
{
    [Serializable]
    public class Stats
    {
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Attack { get; set; }
        public int SpecialAttack { get; set; }
    }
}