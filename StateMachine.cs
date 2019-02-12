using System;

namespace Utils
{
    public class StateMachine<TState> where TState : Enum
    {
        public StateContainter this[TState state] => throw new NotImplementedException();

        public void Send<TMessage>(TMessage message) => throw new NotImplementedException();

        public class StateContainter
        {
            public StateContainter Map<TMessage>(Func<TMessage, TState> mapping) => throw new NotImplementedException();
        }
    }
}