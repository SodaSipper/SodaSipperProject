using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
    public List<Upgrade> Upgrades = new List<Upgrade>();

    private void FixedUpdate()
    {
        int multiplier = 1;
        int spm = 0;
        for (int i = 0; i < Upgrades.Count; i++)
        {
            multiplier *= Upgrades[i].SipMultiplier;
            spm += Upgrades[i].SipsPerMinute;
        }
        CounterSystem.Instance.multiplier = multiplier;
        CounterSystem.Instance.sodaPerMinute = spm;
    }
}