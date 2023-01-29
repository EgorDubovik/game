using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnWeapon : MonoBehaviour
{

    public GameObject[] weapons;
    public GameObject[] spawnPlaces;
    private float timePassed  = 0.0f;
    private float period = 2f;

    // Start is called before the first frame update
    void Start()
    {
        dropNewWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > period ) {
            timePassed = 0;
            dropNewWeapon();
        }
    }

    private void dropNewWeapon(){
        int spawnIndex = Random.Range(0,spawnPlaces.Length);
        int weaponIndex = Random.Range(0,weapons.Length);

        if(spawnPlaces[spawnIndex].transform.childCount == 0){
            GameObject newWeapon = Instantiate(weapons[weaponIndex], spawnPlaces[spawnIndex].transform.position,Quaternion.identity);
            newWeapon.transform.parent = spawnPlaces[spawnIndex].transform;
        }
    }
}
