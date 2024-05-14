using System;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField, Min(1)] private float MaxHealth = 10;

    protected float Health;

    public event Action<float, float> HealthChenged;

    private void Start()
    {
        Health = MaxHealth;
        HealthChenged?.Invoke(Health, MaxHealth);
    }

    private void ChengeHealth(float value)
    {
        Health = Mathf.Clamp(Health + value, 0, MaxHealth);
        HealthChenged?.Invoke(Health, MaxHealth);
    }

    public void TakeDamage(float damage)
    {
        ChengeHealth(-Mathf.Abs(damage));
    }

    public void Heal(float heal)
    {
        ChengeHealth(Mathf.Abs(heal));
    }
}
