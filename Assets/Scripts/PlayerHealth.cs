using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;

    // public variables 
    public Slider m_Slider;
    public Image fill;
    public float Hp = 100f ;


    private void Start()
    {
        if (!Instance)
            Instance = this;
    }


    private void Update()
    {
        HealthBarController();
        m_Slider.value = Hp;

        if (Hp <= 0)
            print("Player died");
    }



    void HealthBarController()
    {
        var sliderFill = m_Slider.value;

        Color orange = new Color(1f, 0.66f, 0.11f);
        Color green = new Color(0f, .63f, .31f);
        Color yellow = new Color(1, .82f, 0);

        if (sliderFill > 75)
        {
            fill.color = green;
        }

        else if (sliderFill > 50 && sliderFill < 75)
        {
            fill.color = Color.Lerp(green, yellow, 1);
        }

        else if (sliderFill > 25 && sliderFill < 50)
        {
            fill.color = Color.Lerp(yellow, orange, 1);
        }

        else if (sliderFill < 25)
        {
            fill.color = Color.Lerp(orange, Color.red, 1);
        }
    }


}
