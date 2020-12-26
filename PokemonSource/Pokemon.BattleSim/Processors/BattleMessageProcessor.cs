using Pokemon.BattleSim.Data;
using Pokemon.BattleSim.Messages;

namespace Pokemon.BattleSim.Processors
{
    public abstract class BattleMessageProcessor<TMessage> : IBattleMessageProcessor where TMessage : BattleRequestMessage
    {
        protected abstract bool InternalIsMessageValid(TMessage message, BattleState state);
        protected abstract void InternalProcessMessage(TMessage message, BattleState state);

        public bool IsMessageValid(BattleRequestMessage message, BattleState state) => InternalIsMessageValid((TMessage)message, state);

        public void ProcessMessage(BattleRequestMessage message, BattleState state) => InternalProcessMessage((TMessage)message, state);
    }
}