using Microsoft.EntityFrameworkCore;
using Pokemon.Battle.State.Models;

namespace Pokemon.Battle.State.Contexts
{
    public class StateDb: DbContext
    {
        public DbSet<BattleState> BattleStates { get; set; }
        public DbSet<BattleMetadata> BattleMetadata { get; set; }
    }
}