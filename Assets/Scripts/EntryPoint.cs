using System;
using UnityEngine;
using UnityEngine.Serialization;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private ValueView _currentPointView;
    [SerializeField] private ValueView _maxPointView;
    [SerializeField] private ValueView _coinsView;
    private AutoClicker _autoClicker;
    private Seller _seller;
    private GameData _gameData;
    private GameController _gameController;
    private IClicker _clicker;

    private void Awake()
    {
        _gameData = new GameData()
        {
            CurrentReadinessPoint = 0,
            MaxReadinessPoint = 50,
            Coins = 0,
            CountPointPerClick = 1,
            CountPointPerAutoClick = 1,
            AutoClickSpeed = 1f,
            PriceMultiplier = 1f
        };
        
        _currentPointView.Init();
        _maxPointView.Init();
        _maxPointView.Display(_gameData.MaxReadinessPoint);
        _coinsView.Init();
        
        _clicker = new ClickerKeyword();
        _seller = new Seller(_gameData, _currentPointView, _coinsView);
        _autoClicker = new AutoClicker(_seller, _gameData);
        _gameController = new GameController(_clicker, _seller, _gameData);
        
        StartCoroutine(_autoClicker.AutoClickRoutine());
    }

    private void Update()
    {
        _clicker.Click();
    }

    private void OnDestroy()
    {
        _gameController.Dispose();
    }
}
