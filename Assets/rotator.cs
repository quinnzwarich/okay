using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour

{

    public float rotationSpeed = 0.3f;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        
        this.GetComponent<Transform>().Rotate(0f, rotationSpeed, 0f);
        
    }
}
