
public class Seller
{
    private readonly GameData _gameData;
    private readonly ValueView _currentPointView;
    private readonly ValueView _coinsView;

    public Seller(GameData gameData, ValueView currentPointView, ValueView coinsView)
    {
        _gameData = gameData;
        _currentPointView = currentPointView;
        _coinsView = coinsView;
    }

    public void CheckScore()
    {
        if (_gameData.CurrentReadinessPoint >= _gameData.MaxReadinessPoint)
        {
            _gameData.Coins += (int)_gameData.PriceMultiplier;
            _gameData.CurrentReadinessPoint = 0;
        }
        
        _coinsView.Display(_gameData.Coins);
        _currentPointView.Display(_gameData.CurrentReadinessPoint);
    }
}