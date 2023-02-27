using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour

{

    // public variables can be accessed across different scripts 

    public float rotationSpeed = 1f;

    // public pickerUpper player;

    public float xCoord = 0f;

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
        xCoord = GameObject.FindGameObjectWithTag("Player").transform.position.x;

        //xCoord = xCoord / 100f;

        //rotationSpeed = rotationSpeed * xCoord;

        this.GetComponent<Transform>().Rotate(0f, rotationSpeed * xCoord, 0f);
        
    }
}
