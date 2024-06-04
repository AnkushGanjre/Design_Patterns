using UnityEngine;

public class EatingState : BaseState
{
    public override void Enter(StateMachine _sm)
    {
        Debug.Log("Entering State: " + _sm.eatingState);
        _sm.indicator.localPosition = new Vector3(-500f, -250f, 0f);
    }
    public override void Exits(StateMachine _sm)
    {
        Debug.Log("Exiting State: " + _sm.eatingState);
    }
}
