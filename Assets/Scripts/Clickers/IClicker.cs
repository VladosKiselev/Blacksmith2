using System;

public interface IClicker
{
    event Action Clicked;
    void Click();
}