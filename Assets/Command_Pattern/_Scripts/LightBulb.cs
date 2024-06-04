using UnityEngine;
using UnityEngine.UI;

public class LightBulb : MonoBehaviour
{
    bool isPowerOn = false;

    public void TogglePower()
    {
        if (isPowerOn)
        {
            GetComponent<Image>().color = Color.black;
            isPowerOn = false;
        }
        else
        {
            GetComponent<Image>().color = Color.white;
            isPowerOn = true;
        }
    }

    public void SetLightColor(Color newColor)
    {
        GetComponent<Image>().color = newColor;
    }

    public void SetRandomLightColor()
    {
        if (!isPowerOn) return;
        GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
