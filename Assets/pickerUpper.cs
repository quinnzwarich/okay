using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickerUpper : MonoBehaviour
{
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("pickup"))
        {
            GameObject.Destroy(collision.collider.gameObject);

            count++;

            Debug.Log("pickup count: " + count);

            // this.GetComponent<AudioSource>().Play();
        }
    }
}
