using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boneco : MonoBehaviour
{
    private Rigidibody2D Corpo;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velX = Input.GetAxis("Horizontal") * 4;
    }
}
 