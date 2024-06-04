using UnityEngine;

public class SleepingState : BaseState
{
    public override void Enter(StateMachine _sm)
    {
        Debug.Log("Entering State: " + _sm.sleepingState);
        _sm.indicator.localPosition = new Vector3(-500f, 100f, 0f);
    }
    public override void Exits(StateMachine _sm)
    {
        Debug.Log("Exiting State: " + _sm.sleepingState);
    }
}
