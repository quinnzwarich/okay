using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    public Rigidbody platform; private bool hasPlayerExited; float timer = 0f;

    void Start()
    {
        platform = GetComponent(typeof(Rigidbody)) as Rigidbody;
        platform.isKinematic = true; platform.useGravity = false;
    }

    void OnCollisionEnter()
    {
        hasPlayerExited = false;
    }

    void OnCollisionExit()
    {
        hasPlayerExited = true;
    }

    void Update()
    {
        if (hasPlayerExited == true)
        {
            timer += Time.deltaTime;
            if (timer > 500000f)
            {
                platform.isKinematic = false; platform.useGravity = true;
        }   }
    }
}

