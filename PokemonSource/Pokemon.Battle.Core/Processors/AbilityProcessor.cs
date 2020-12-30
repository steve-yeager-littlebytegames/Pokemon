using Pokemon.Combat.Core.Requests;
using Pokemon.Gamedata;

namespace Pokemon.Combat.Core.Processors
{
    internal class AbilityProcessor : TurnRequestProcessor<AbilityTurnRequest>
    {
        protected override bool InternalIsMessageValid(AbilityTurnRequest turnRequest, BattleState state, GameData gameData)
        {
            var source = state.GetPokemon(turnRequest.SourcePokemonId);
            var isAlive = source.Health > 0;
            var hasPoints = source.GetAbility(turnRequest.AbilityId).Points > 0;
            return isAlive && hasPoints;
        }

        protected override void InternalProcessMessage(AbilityTurnRequest turnRequest, BattleState state, GameData gameData)
        {
            var source = state.GetPokemon(turnRequest.SourcePokemonId);
            var abilityState = source.GetAbility(turnRequest.AbilityId);
            abilityState.Points--;

            var target = state.GetPokemon(turnRequest.TargetPokemonId);
            var abilityData = gameData.AbilityDefinitions[abilityState.AbilityId];
            target.Health -= abilityData.Damage;
        }
    }
}