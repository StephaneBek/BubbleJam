using UnityEngine;

public class ConfigurablePowerUp : MonoBehaviour
{
    public PowerUpScriptableObject data;

    public void Start()
    {
        var sRenderer = GetComponent<SpriteRenderer>();
        sRenderer.color = data.powerUpColor;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        data.Apply(other.gameObject);
        GameObject.Destroy(gameObject);
    }
}
