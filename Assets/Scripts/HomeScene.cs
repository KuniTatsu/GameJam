using ClickerGame.Models;
using UnityEngine;
using UnityEngine.UI;

public class HomeScene : MonoBehaviour
{
    [SerializeField]
    private ScoreView _score = null;

    [SerializeField]
    private Button _scoreButton = null;

    [SerializeField]
    private CurrencyType _currencyType = CurrencyType.None;

    [SerializeField]
    private double _quantity = 1;

    void Start()
    {
        var game = Game.Instance;
        _score.DataSource = game.CashInventory;

        var e = new Button.ButtonClickedEvent();
        e.AddListener(() =>
        {
            var q = _quantity;
            foreach (var e in game.EnhancerInventory.Enhancers)
            {
                if (e.ItemMaster != null) { continue; }
                q *= e.Factor;

            }


            var c = new Currency(_currencyType, _quantity);
            var cc = game.CashInventory.Add(c);
        });
        _scoreButton.onClick = e;
    }
}