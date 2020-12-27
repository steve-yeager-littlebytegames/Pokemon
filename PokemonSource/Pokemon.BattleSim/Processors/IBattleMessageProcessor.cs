using Pokemon.BattleSim.Data;
using Pokemon.BattleSim.Messages;
using Pokemon.Core.Data;

namespace Pokemon.BattleSim.Processors
{
    public interface IBattleMessageProcessor
    {
        bool IsMessageValid(BattleRequestMessage message, BattleState state, GameData gameData);
        void ProcessMessage(BattleRequestMessage message, BattleState state, GameData gameData);
    }
}