using UnityEngine;

public class DistanceActuator : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public float moveSpeed = 5f;
    public float distanceThreshold = 5f;

    void Update()
    {
        if (object1 != null && object2 != null)
        {
            float distance = CalculateDistance(object1, object2);
            ActuateBasedOnDistance(distance);
        }
    }

    float CalculateDistance(GameObject obj1, GameObject obj2)
    {
        Vector3 pos1 = obj1.GetComponent<ObjectBehavior>().Position;
        Vector3 pos2 = obj2.GetComponent<ObjectBehavior>().Position;
        return Vector3.Distance(pos1, pos2);
    }

    void ActuateBasedOnDistance(float distance)
    {
        if (distance > distanceThreshold)
        {
            // Move object1 towards object2
            Vector3 direction = (object2.transform.position - object1.transform.position).normalized;
            object1.transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else
        {
            // Stop movement or react differently if needed
            Debug.Log("Object is within threshold distance.");
        }
    }
}
