using Pokemon.BattleSim.Data;
using Pokemon.BattleSim.Messages;

namespace Pokemon.BattleSim.Processors
{
    public interface IBattleMessageProcessor
    {
        bool IsMessageValid(BattleRequestMessage message, BattleState state);
        void ProcessMessage(BattleRequestMessage message, BattleState state);
    }
}