using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;

    void Update()
    {
        if (object1 != null && object2 != null)
        {
            float distance = CalculateDistance(object1, object2);
            Debug.Log($"Distance between {object1.name} and {object2.name}: {distance}");
        }
    }

    float CalculateDistance(GameObject obj1, GameObject obj2)
    {
        Vector3 pos1 = obj1.GetComponent<ObjectBehavior>().Position;
        Vector3 pos2 = obj2.GetComponent<ObjectBehavior>().Position;
        return Vector3.Distance(pos1, pos2);
    }
}
