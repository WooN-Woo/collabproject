using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    float healtCounter;
    [SerializeField] float healtTime;
    [SerializeField] GameObject heart;

    bool addhealt = false;

    private void Update()
    {
        menuController();
        healtCounter -= Time.deltaTime;
    }
    public void menuController()
    {
        if(healtCounter<= 0)
        {
            addhealt= true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                healtCounter = healtTime;
            }
            heart.SetActive(true);
        }
        else
        {
            addhealt= false;
        }

        if(addhealt == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                // buraya scripte healt scriptini çaðýrýp buraya örnek currentHealt+=25 tarzý biþey yazýlcak
                heart.SetActive(false);
            }
        }
       
    }
}
