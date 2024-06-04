using UnityEngine;
using UnityEngine.UI;

public class ChangeColorCommand : ICommand
{
    // Stored Lightbulb Receiver
    LightBulb _lightBulb;

    // Stored previous Color
    Color _previousColor;

    // Constructor to set lightbulb
    public ChangeColorCommand(LightBulb lightBulb)
    {
        _lightBulb = lightBulb;
        _previousColor = lightBulb.GetComponent<Image>().color;
    }

    public void Execute()
    {
        _lightBulb.SetRandomLightColor();
    }

    public void Undo()
    {
        _lightBulb.SetLightColor(_previousColor);
    }
}
