using UnityEngine;

public class DamageButton : HealthChengerButton
{
    protected override void OnChengeHealth()
    {
        Entity.TakeDamage(Random.Range(MinHealthPoint, MaxHealthPoint));
    }
}
