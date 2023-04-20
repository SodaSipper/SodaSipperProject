using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpgradeHolder : MonoBehaviour
{
    [SerializeField] private Upgrade upgrade;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text descriptionText;

    private void Awake()
    {
        nameText.text = upgrade.Name + ": " + upgrade.Cost;
        descriptionText.text = upgrade.Description + (upgrade.Quote != "" ? " \"" + upgrade.Quote + "\"" : "");
    }

    public void AddEffect()
    {
        if(CounterSystem.Instance.counter >= upgrade.Cost)
        {
            GameManager.Instance.Upgrades.Add(upgrade);
            GetComponent<Button>().interactable = false;
            CounterSystem.Instance.counter -= upgrade.Cost;
        }
    }
}