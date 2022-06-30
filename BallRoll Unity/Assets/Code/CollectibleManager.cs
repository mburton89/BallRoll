using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private int _totalCoinsInLevel;
    private int _collectedCoinsInLevel;
    private int _totalCoinsInGame;

    public TextMeshProUGUI coinCount;

    private void Awake()
    {
        Instance = this;
        _totalCoinsInLevel = FindObjectsOfType<Collectible>().Length;
        DisplayCoinCount();
    }

    void DisplayCoinCount()
    {
        coinCount.SetText(_collectedCoinsInLevel + "/" + _totalCoinsInLevel);
    }

    public void IncrementCollectedCoinCount()
    {
        _collectedCoinsInLevel++;
        DisplayCoinCount();

        if (_collectedCoinsInLevel >= _totalCoinsInLevel)
        {
            YouWinMenu.Instance.Show("You Win!");
        }
    }
}
