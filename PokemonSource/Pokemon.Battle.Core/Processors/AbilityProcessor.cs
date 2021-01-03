using Pokemon.Combat.Core.Models;
using Pokemon.Combat.Core.Requests;
using Pokemon.Gamedata;

namespace Pokemon.Combat.Core.Processors
{
    internal class AbilityProcessor : TurnRequestProcessor<AbilityTurnRequest>
    {
        protected override bool InternalIsMessageValid(AbilityTurnRequest turnRequest, Battle battle, GameData gameData)
        {
            var source = battle.GetMonster(turnRequest.SourceMonsterId);
            var isAlive = source.Health > 0;
            var hasPoints = source.GetAbility(turnRequest.AbilityId).Points > 0;
            return isAlive && hasPoints;
        }

        protected override void InternalProcessMessage(AbilityTurnRequest turnRequest, Battle battle, GameData gameData)
        {
            var source = battle.GetMonster(turnRequest.SourceMonsterId);
            var ability = source.GetAbility(turnRequest.AbilityId);
            ability.Points--;

            var target = battle.GetMonster(turnRequest.TargetPokemonId);
            var abilityData = gameData.AbilityDefinitions[ability.DataId];
            target.Health -= abilityData.Damage;
        }
    }
}