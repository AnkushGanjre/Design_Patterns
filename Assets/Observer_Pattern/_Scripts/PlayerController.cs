using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static event Action OnHealthGain;
    public static event Action OnHealthLost;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Notify the observers when the event is called
            OnHealthGain?.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            // Notify the observers when the event is called
            OnHealthLost?.Invoke();
        }
    }
}
