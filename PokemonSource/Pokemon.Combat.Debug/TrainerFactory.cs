using System;
using System.Collections.Generic;
using Pokemon.Combat.Core.Models;

namespace Pokemon.Combat.Debug
{
    public static class TrainerFactory
    {
        public static Trainer Create(string name)
        {
            var trainer = new Trainer(Guid.NewGuid(), name, new List<Monster>
            {
                CreateMonster(),
                CreateMonster(),
                CreateMonster(),
            });
            return trainer;
        }

        private static Monster CreateMonster()
        {
        }
    }
}