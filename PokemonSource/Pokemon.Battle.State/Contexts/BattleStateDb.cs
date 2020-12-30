using Microsoft.EntityFrameworkCore;
using Pokemon.Combat.State.Models;

namespace Pokemon.Combat.State.Contexts
{
    public class BattleStateDb: DbContext
    {
        public DbSet<BattleState> BattleStates { get; set; }
        public DbSet<BattleMetadata> BattleMetadata { get; set; }
    }
}