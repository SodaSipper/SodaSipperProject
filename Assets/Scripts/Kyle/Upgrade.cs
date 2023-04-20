using UnityEngine;
[CreateAssetMenu(fileName = "New Upgrade", menuName = "Scriptable Objects/Upgrade")]
public class Upgrade : ScriptableObject
{
    public int Cost;
    public string Name;
    public string Description;
    public string Quote;
    public int SipsPerMinute;
    public int SipMultiplier;
}