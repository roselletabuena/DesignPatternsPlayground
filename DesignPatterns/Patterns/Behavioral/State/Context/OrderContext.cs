using DesignPatterns.Patterns.Behavioral.State.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioral.State.Context
{
    internal class OrderContext
    {
        private IOrderState _currentState;

        public OrderContext()
        {
            _currentState = new NewOrderState();
        }

        public void SetState(IOrderState state)
        {
            _currentState = state;
        }


        public void ProcessOrder() => _currentState.Process(this);
        public void ShipOrder() => _currentState.Ship(this);
        public void CancelOrder() => _currentState.Cancel(this);

    }
}
