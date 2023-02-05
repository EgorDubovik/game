using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helth : MonoBehaviour
{

    private float helthScore;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {   
        helthScore = 100f;
        GetDamage(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage(float damage){
        Debug.Log("Get Damage");
        if(helthScore - damage >0)
            helthScore -= damage;
        else
            helthScore = 0;
        
        slider.value = helthScore;

        
    }



}
