

public class TogglePowerCommand : ICommand
{
    // Stored lightbulb receiver
    LightBulb _lightbulb;

    // contructor to store light bulb reference
    public TogglePowerCommand(LightBulb lightbulb)
    {
        _lightbulb = lightbulb;
    }

    // Execute the stored logic
    public void Execute()
    {
        _lightbulb.TogglePower();
    }

    public void Undo()
    {
        _lightbulb.TogglePower();
    }
}
