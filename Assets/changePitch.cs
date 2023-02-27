using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePitch : MonoBehaviour
{
    AudioSource song;

    public float xCoord = 0f;

    // Start is called before the first frame update
    void Start()
    {
        song = GetComponent<AudioSource>();
        song.pitch = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        xCoord = GameObject.FindGameObjectWithTag("Player").transform.position.x;

        xCoord = Mathf.Clamp(xCoord, -2f, 2f);

        song.pitch = xCoord;
    }
}
