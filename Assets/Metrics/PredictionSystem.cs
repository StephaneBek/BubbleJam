using UnityEngine;

public class PredictionSystem : MonoBehaviour
{
    public GameObject player;
    public float predictionTime = 1.0f; // Time in seconds for prediction

    void Update()
    {
        if (player != null)
        {
            Vector3 predictedPosition = PredictFuturePosition(player, predictionTime);
            Debug.Log($"Predicted Position after {predictionTime} seconds: {predictedPosition}");
        }
    }

    Vector3 PredictFuturePosition(GameObject player, float time)
    {
        Vector3 currentPosition = player.transform.position;
        Vector3 currentVelocity = player.GetComponent<PlayerMovement>().velocity;
        return currentPosition + (currentVelocity * time);
    }
}
