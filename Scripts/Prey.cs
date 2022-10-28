using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Prey : MonoBehaviour
{
    private PopulationManager GetSliderValues();

    public float prey;

    public Prey()
    {
        prey = GetPreyValue();
    }
    public float GetPreyValue()
    {
       GetSliderValues();
        return prey; 

    }
}