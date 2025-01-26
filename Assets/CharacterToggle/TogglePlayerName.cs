using UnityEngine;
using UnityEngine.UI;

public class TogglePlayerName : MonoBehaviour
{
    public Text playerNameText;

    public void ToggleName()
    {
        if (playerNameText != null)
        {
            playerNameText.gameObject.SetActive(!playerNameText.gameObject.activeSelf);
        }
    }
}
