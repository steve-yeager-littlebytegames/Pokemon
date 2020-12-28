using Pokemon.BattleSim.Data;
using Pokemon.BattleSim.Messages;
using Pokemon.Gamedata;

namespace Pokemon.BattleSim.Processors
{
    public abstract class BattleMessageProcessor<TMessage> : IBattleMessageProcessor where TMessage : BattleRequestMessage
    {
        protected abstract bool InternalIsMessageValid(TMessage request, BattleState state, GameData gameData);
        protected abstract void InternalProcessMessage(TMessage request, BattleState state, GameData gameData);

        public bool IsMessageValid(BattleRequestMessage message, BattleState state, GameData gameData) => InternalIsMessageValid((TMessage)message, state, gameData);

        public void ProcessMessage(BattleRequestMessage message, BattleState state, GameData gameData) => InternalProcessMessage((TMessage)message, state, gameData);
    }
}