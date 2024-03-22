using System;
using UnityEngine;

public class ClickerKeyword : IClicker
{
    private readonly KeyCode _keyCode;
    
    public event Action Clicked;

    public ClickerKeyword(KeyCode keyCode = KeyCode.Space)
    {
        _keyCode = keyCode;
    }
    
    public void Click()
    {
        if (Input.GetKeyDown(_keyCode))
        {
            Clicked?.Invoke();
        }
    }
}