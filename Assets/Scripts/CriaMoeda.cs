using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CriaMoeda : MonoBehaviour
{
    public GameObject moeda;
    
    // Start is called before the first frame update
    void Start()
    {
        
        CriaReta();
        CriaReta2();
        
    }
    void CriaReta(){
        float y;
        for (float x = -2; x < 3; x+=1.0f)
        {            
                // reta
                y = 1.0f*x+0;
                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
        }
    }
    void CriaReta2()
    {
        float y;
        for (float x = -2; x < 3; x += 1.0f)
        {
            // reta
            y = -1.0f * x -0;
            Instantiate(moeda, new Vector3(x, y, -2), Quaternion.identity);
        }
    }
    

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
