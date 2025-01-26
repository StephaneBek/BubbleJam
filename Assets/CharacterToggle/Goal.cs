using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerToggle playerToggle = other.GetComponent<PlayerToggle>();
            if (playerToggle != null)
            {
                playerToggle.ToggleState();
            }

            Debug.Log("Goal reached!");
        }
    }
}
