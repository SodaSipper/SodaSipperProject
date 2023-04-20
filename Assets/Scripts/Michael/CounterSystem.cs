using UnityEngine;
using TMPro;

public class CounterSystem : Singleton<CounterSystem>
{
    public int counter = 0;
    public TMP_Text counterUI;
    public int multiplier = 1;
    public int sodaPerMinute;

    public void Clicker(){
        counter += multiplier;
    }

    float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(sodaPerMinute != 0 && timer >= 60 / sodaPerMinute)
        {
            timer -= 60 / sodaPerMinute;
            counter += 1;
        }
        counterUI.text = "Sodas Sipped: " + counter;
    }
}