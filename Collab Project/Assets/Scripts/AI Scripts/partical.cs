using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;

public class partical : MonoBehaviour
{
    public GameObject gm;

    float particalCounter = 2f;

    private void Update()
    {
        particalCounter -= Time.deltaTime;
        if (particalCounter <= 0) Invoke(nameof(destroyGm), .1f);
    }

    private void destroyGm()
    {
        Destroy(gm);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "ground")
        {
            Destroy(gm);
        }
;
    }

}
