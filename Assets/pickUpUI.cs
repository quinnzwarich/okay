using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pickUpUI : MonoBehaviour
{
    public pickerUpper player;

    // Start is called before the first frame update
    void Start()
    {
        player.count = 0;
    }

    // Update is called once per frame
    void Update()
    {   
        this.GetComponent<TextMeshProUGUI>().text = "pickup count: " + player.count; 
    }
}
