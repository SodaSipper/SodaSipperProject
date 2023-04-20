using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterSystem : MonoBehaviour
{
    int counter;
    public TMP_Text counterUI;
    int multiplier;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        multiplier = 1;
    }

    public void Clicker(){
        counter += multiplier;
    }

    // Update is called once per frame
    void Update()
    {
        counterUI.text = "Sodas: " + counter;
    }
}