using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class TextHealhBar : Bar
{
    private TMP_Text _healthText;

    private void Awake()
    {
        _healthText = GetComponent<TMP_Text>();
    }

    protected override void OnHealthChenge(float health, float maxHealth)
    {
        _healthText.text = $"{health} / {maxHealth}";
    }
}
