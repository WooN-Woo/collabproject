using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{
    public Transform camerapos;
    void Update()
    {
        transform.position = camerapos.position;
    }
}
