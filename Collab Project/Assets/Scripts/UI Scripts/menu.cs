using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    HealtScript HealtScript;
    float healtCounter;
    [SerializeField] float healtTime;
    [SerializeField] GameObject heart;
    [SerializeField] GameObject sword;
    [SerializeField] GameObject swordImage;
    [SerializeField] GameObject bow;
    [SerializeField] GameObject bowImage;


    bool addhealt = false;
    private void Awake()
    {
        HealtScript = FindObjectOfType<HealtScript>();
    }
    private void Start()
    {
        weaponStarter();
    }

    private void Update()
    {
        menuController();
        healtCounter -= Time.deltaTime;
        weaponController();
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
                HealtScript.currentHealt += 30;
                heart.SetActive(false);
            }
        }
       
    }

    public void weaponController()
    {
        if (Input.GetKeyDown("1"))
        {
            sword.SetActive(true);
            swordImage.SetActive(false);
            bow.SetActive(false);
            bowImage.SetActive(true);
        }

        if(Input.GetKeyDown("2"))
        {
            sword.SetActive(false);
            swordImage.SetActive(true);
            bow.SetActive(true);
            bowImage.SetActive(false);
        }
    }

    private void weaponStarter()
    {
        sword.SetActive(true);
        swordImage.SetActive(false);
        bow.SetActive(false);
        bowImage.SetActive(true);
    }

    
}
