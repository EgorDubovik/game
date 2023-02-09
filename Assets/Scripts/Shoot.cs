using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public GameObject fierPlace;
    private WeaponController weaponController;
    private bool isShoot = true;
    private float lasTimeShoot;

    void Start(){
        
        weaponController = GetComponent<WeaponController>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")){
            if(weaponController.isGunPickedUp){
                if(weaponController.bulet.GetComponent<BuletController>().isAuto)
                    isShoot = true;
                if(isShoot){
                    fire();
                    isShoot = false;
                }
            }
        }
        if(Input.GetButtonDown("Fire1")) isShoot = true;
    }

    void fire(){

        if(lasTimeShoot+weaponController.bulet.GetComponent<BuletController>().fierSpeed <= Time.time){
            lasTimeShoot = Time.time;
            GameObject newBulet = Instantiate(weaponController.bulet, fierPlace.transform.position, fierPlace.transform.rotation);
            Destroy(newBulet,5);
        }
    }

}
