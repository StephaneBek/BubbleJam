using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject gameController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerToggle playerToggle = other.GetComponent<PlayerToggle>();
            if (playerToggle != null)
            {
                playerToggle.ToggleState();
            }
            
            ToggleGameController();
            Debug.Log("Goal reached! Game Controller toggled.");
        }
    }

    private void ToggleGameController()
    {
        if (gameController != null)
        {
            gameController.SetActive(!gameController.activeSelf);
        }
    }
}
