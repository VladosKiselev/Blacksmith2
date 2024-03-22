using System.Collections;
using UnityEngine;

public class AutoClicker
{
    private readonly Seller _seller;
    private readonly GameData _gameData;
    private readonly WaitForSecondsRealtime _wait;

    public AutoClicker(Seller seller, GameData gameData)
    {
        _seller = seller;
        _gameData = gameData;
        _wait = new WaitForSecondsRealtime(_gameData.AutoClickSpeed);
    }
    
    public IEnumerator AutoClickRoutine()
    {
        while (true)
        {
            _gameData.CurrentReadinessPoint += _gameData.CountPointPerAutoClick;
            _seller.CheckScore();
            yield return _wait;
        }
    }
}