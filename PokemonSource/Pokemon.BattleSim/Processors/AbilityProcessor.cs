using Pokemon.BattleSim.Data;
using Pokemon.BattleSim.Messages;
using Pokemon.Core.Data;

namespace Pokemon.BattleSim.Processors
{
    public class AbilityProcessor : BattleMessageProcessor<AbilityRequest>
    {
        protected override bool InternalIsMessageValid(AbilityRequest request, BattleState state, GameData gameData)
        {
            var source = state.GetPokemon(request.SourcePokemonId);
            var isAlive = source.Health > 0;
            var hasPoints = source.GetAbility(request.AbilityId).Points > 0;
            return isAlive && hasPoints;
        }

        protected override void InternalProcessMessage(AbilityRequest request, BattleState state, GameData gameData)
        {
            var source = state.GetPokemon(request.SourcePokemonId);
            var abilityState = source.GetAbility(request.AbilityId);
            abilityState.Points--;

            var target = state.GetPokemon(request.TargetPokemonId);
            var abilityData = gameData.AbilityDefinitions[abilityState.AbilityId];
            target.Health -= abilityData.Damage;
        }
    }
}