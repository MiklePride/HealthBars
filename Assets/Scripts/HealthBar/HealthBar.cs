using UnityEngine;
using UnityEngine.UI;

public class HealthBar : Bar
{
    [SerializeField] private Slider _health;

    protected override void OnHealthChenge(float health, float maxHealth)
    {
        float healthAsPercentage = health / maxHealth;
        _health.value = Mathf.Clamp01(healthAsPercentage);
    }
}
