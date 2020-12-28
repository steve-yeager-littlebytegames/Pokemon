using Pokemon.BattleSim.Data;
using Pokemon.BattleSim.Messages;
using Pokemon.Gamedata;

namespace Pokemon.BattleSim.Processors
{
    public interface IBattleMessageProcessor
    {
        bool IsMessageValid(BattleRequestMessage message, BattleState state, GameData gameData);
        void ProcessMessage(BattleRequestMessage message, BattleState state, GameData gameData);
    }
}