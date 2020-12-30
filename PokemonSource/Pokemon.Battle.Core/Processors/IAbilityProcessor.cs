using Pokemon.Combat.Core.Models;
using Pokemon.Combat.Core.Requests;
using Pokemon.Gamedata;

namespace Pokemon.Combat.Core.Processors
{
    public interface IAbilityProcessor
    {
        bool IsMessageValid(TurnRequest request, Battle battle, GameData gameData);
        void ProcessMessage(TurnRequest request, Battle battle, GameData gameData);
    }
}