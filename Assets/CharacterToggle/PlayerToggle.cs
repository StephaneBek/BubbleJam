using UnityEngine;

public class PlayerToggle : MonoBehaviour
{
    private bool isToggled = false;

    public void ToggleState()
    {
        isToggled = !isToggled;
        Debug.Log("Player state toggled: " + isToggled);
    }
}
