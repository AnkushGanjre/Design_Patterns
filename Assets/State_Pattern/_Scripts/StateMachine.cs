using UnityEngine;

public class StateMachine : MonoBehaviour
{
    BaseState currentState;
    public SleepingState sleepingState = new SleepingState();
    public JumpingState jumpingState = new JumpingState();
    public EatingState eatingState = new EatingState();
    public WalkingState walkingState = new WalkingState();

    public Transform indicator;

    private void Awake()
    {
        indicator = GameObject.Find("Indicator").GetComponent<Transform>();
    }

    void Start()
    {
        currentState = sleepingState;
        if (currentState != null)
        {
            currentState.Enter(this);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            ChangeState(jumpingState);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeState(eatingState);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeState(walkingState);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeState(sleepingState);
        }
    }

    public void ChangeState(BaseState newState)
    {
        if (currentState != null)
        {
            if (currentState.Equals(newState))
            {
                Debug.Log("Same State Can't Change");
                return;
            }
            currentState.Exits(this);
        }

        currentState = newState;
        currentState.Enter(this);
    }
}
