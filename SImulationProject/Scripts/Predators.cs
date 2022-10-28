using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Predator : MonoBehaviour
{
    public PopulationManager GetSliderValues();

    public float predator; 
    public Predator()
    {
        predator = GetPredatorValue();
    }
    public float GetPredatorValue()
    {
        GetSliderValues();
        return predator;
    }

  
}
