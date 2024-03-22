using System;

public class Blacksmith : IDisposable
{
    private readonly IClicker _clicker;
    private readonly Seller _seller;
    private readonly GameData _gameData;

    public Blacksmith(IClicker clicker, Seller seller, GameData gameData)
    {
        _gameData = gameData;
        _clicker = clicker;
        _seller = seller;
        _clicker.Clicked += OnClick;
    }
    
    public void Dispose()
    {
        _clicker.Clicked -= OnClick;
    }
    
    private void OnClick()
    {
        _gameData.CurrentReadinessPoint += _gameData.CountPointPerClick;
        _seller.CheckScore();
    }

}