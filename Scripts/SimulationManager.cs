using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopulationManager : MonoBehaviour
{
    private Prey prey;
    private Predator predator;
    public Slider preySlider;
    public Slider predatorSlider;

    public Button calculateButton;

    public GameObject preyTextObject;
    public GameObject predatorTextObject;
    public GameObject preyaliveTextObject;


    private TextMeshProUGUI preyText { get; set; }
    private TextMeshProUGUI predatorText { get; set; }
    private TextMeshProUGUI preyaliveText { get; set; }
    public float value { get; internal set; }



    // Start is called before the first frame update
    void Start()
    {

        preyText = preyTextObject.GetComponent<TextMeshProUGUI>();
        predatorText = predatorTextObject.GetComponent<TextMeshProUGUI>();
        preyaliveText = preyaliveTextObject.GetComponent<TextMeshProUGUI>();

        GetValuesFromSliders();

    }

  

    // Update is called once per frame
    void Update()
    {
        preyText.text = "Prey: " + prey.GetPreyValue().ToString();
        predatorText.text = "Predator: " + predator.GetPredatorValue().ToString();

    }


    public void CalculateResults()
    {
        GetValuesFromSliders();
        if(preySlider.value > predatorSlider.value)
        {
            preyaliveText.text = "Prey Alive: Yes";
        } else
        {
            preyaliveText.text = "Prey Alive: No";
        }
       

    }
    public void SlidersChanged(float newValue)
    {
        GetValuesFromSliders();
    }
    public void GetValuesFromSliders()
    {
        float prey = preySlider.value;
        float predator = predatorSlider.value;

    }
}