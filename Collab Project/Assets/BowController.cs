using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowController : MonoBehaviour
{
    [SerializeField]
    private Text firePowerText;

    [SerializeField]
    private WeaponController weapon;

    [SerializeField]
    private string enemyTag;

    //[SerializeField]
    //private string enemyTag;

    [SerializeField]
    private float firePowerSpeed;

    private float firePower;

    [SerializeField]
    private float rotateSpeed;

    [SerializeField]
    private float minRotation;

    [SerializeField]
    private float maxRotation;

    private float mouseY;

    private bool fire;

    void Start()
    {
        //weapon.SetEnemyTag(enemyTag);
        weapon.Reload();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseY.visible = false;
        mouseY = Mathf.Clamp(mouseY, minRotation, maxRotation);
        weapon.transform.localRotation = Quaternion.Euler(mouseY, weapon.transform.localEulerAngles.y, weapon.transform.localEulerAngles.z);
        
        if (Input.GetMouseButtonDown(0))
        {
            fire = true;
        }

        if (fire && firePower < maxFirePower)
        {
            firePower += Time.deltaTime * firePowerSpeed;
        }

        if (fire && Input.GetButtonUp(0))
        {
            weapon.Fire(firePower);
            firePower = 0;
            fire = false;
        }

        if(fire)
        {
            firePowerText.text = firePower.ToString();
        }
    }
}
