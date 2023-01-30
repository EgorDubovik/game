using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helth : MonoBehaviour
{

    private float helthScore;
    // Start is called before the first frame update
    void Start()
    {   
        helthScore = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage(float damage){
        Debug.Log(helthScore);
        if(helthScore - damage >0)
            helthScore -= damage;
        else
            helthScore = 0;

        
    }



}
