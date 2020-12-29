using Pokemon.Battle.Core.Messages;
using Pokemon.Gamedata;

namespace Pokemon.Battle.Core.Processors
{
    public interface IBattleMessageProcessor
    {
        bool IsMessageValid(TurnRequest message, BattleState state, GameData gameData);
        void ProcessMessage(TurnRequest message, BattleState state, GameData gameData);
    }
}