using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ValueViewTMP : ValueView
{
    private TextMeshProUGUI _text;

    public override void Init()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    public override void Display(int score)
    {
        _text.text = score.ToString();
    }
}