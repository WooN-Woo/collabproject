using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healtBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    HealtScript HealtScript;

    private void Awake()
    {
        HealtScript= FindObjectOfType<HealtScript>();
    }

    private void Start()
    {
        setMaxHealt();
    }

    private void Update()
    {
        setHealt();
    }

    public void setMaxHealt()
    {
        slider.maxValue = HealtScript.maxHealt;
        slider.value = HealtScript.maxHealt;
    }

    public void setHealt()
    {
        slider.value = HealtScript.currentHealt;
    }
}
