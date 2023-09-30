using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healtBar : MonoBehaviour
{
    [SerializeField] Slider slider;

    public void setMaxHealt(int healt)
    {
        slider.maxValue = healt;
        slider.value = healt;
    }

    public void setHealt(int healt)
    {
        slider.value = healt;
    }
}
