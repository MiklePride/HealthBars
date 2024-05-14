using UnityEngine;
using UnityEngine.UI;

public abstract class HealthChengerButton : MonoBehaviour
{
    [SerializeField] protected Entity Entity;
    [SerializeField] protected Button Button;
    [SerializeField, Min(1)] protected int MinHealthPoint;
    [SerializeField, Min(1)] protected int MaxHealthPoint;

    private void OnValidate()
    {
        if (MinHealthPoint > MaxHealthPoint)
            MaxHealthPoint = MinHealthPoint;
    }

    private void OnEnable()
    {
        Button.onClick.AddListener(OnChengeHealth);
    }

    private void OnDestroy()
    {
        Button.onClick.RemoveListener(OnChengeHealth);
    }

    protected abstract void OnChengeHealth();
}
