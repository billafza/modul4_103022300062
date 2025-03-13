using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300062
{
    internal class FanLaptop
    {
        public enum FanState { Quiet, Balanced, Performance, Turbo};
        public enum Trigger { ModeDown, ModeUp, TurboShortcut };

        class transition
        {
            public FanState prevState;
            public FanState nextState;
            public Trigger trigger;

            public transition(FanState prevState, FanState nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }
        transition[] transitions =
        {
            new transition(FanState.Quiet, FanState.Balanced, Trigger.ModeUp),
            new transition(FanState.Quiet, FanState.Turbo, Trigger.TurboShortcut),
            new transition(FanState.Balanced, FanState.Performance, Trigger.ModeUp),
            new transition(FanState.Balanced, FanState.Quiet, Trigger.ModeDown),
            new transition(FanState.Performance, FanState.Balanced, Trigger.ModeDown),
            new transition(FanState.Performance, FanState.Turbo, Trigger.ModeUp),
            new transition(FanState.Turbo, FanState.Quiet, Trigger.TurboShortcut),
            new transition(FanState.Turbo, FanState.Performance, Trigger.ModeDown)
        };

        public FanState currentState;

        public FanState getNextState(FanState prevState, Trigger trigger)
        {
            FanState nextState = prevState;
            for (int i = 0; i < transitions.Length; i++) {
                if (transitions[i].prevState == prevState && transitions[i].trigger == trigger)
                    nextState = transitions[i].nextState;
            }
            return nextState;
        }

        public void activateTrigger(Trigger trigger)
        {
            FanState nextState = getNextState(currentState, trigger);
            currentState = nextState;
        }
    }
}
