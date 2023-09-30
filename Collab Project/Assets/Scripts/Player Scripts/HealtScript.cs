using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtScript : MonoBehaviour
{
    public int maxHealt;
    public int currentHealt;

    private void Start()
    {
        currentHealt = maxHealt;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            currentHealt -= 20;
        }
    }
}