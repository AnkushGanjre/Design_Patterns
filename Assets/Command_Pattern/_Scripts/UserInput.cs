using UnityEngine;

public class UserInput : MonoBehaviour
{
    public LightBulb _lightbulb;
    LightApp _lightApp;

    void Start()
    {
        // Setup Invoker
        _lightApp = new LightApp();
    }

    void Update()
    {
        // if we press button -- tell invoker to execute the command
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ICommand togglePowerCommand = new TogglePowerCommand(_lightbulb);
            _lightApp.AddCommand(togglePowerCommand);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ICommand changeColorCommand = new ChangeColorCommand(_lightbulb);
            _lightApp.AddCommand(changeColorCommand);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            _lightApp.UndoCommand();
        }
    }
}
