using UnityEngine;

public class HealButton : HealthChengerButton
{
    protected override void OnChengeHealth()
    {
        Entity.Heal(Random.Range(MinHealthPoint, MaxHealthPoint));
    }
}
