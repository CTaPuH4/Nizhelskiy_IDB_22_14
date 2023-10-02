using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube : MonoBehaviour
{
    private int k = 0;
    public GameObject CUBE;
    public Text PushCount;
    public Text Button;



    // Start is called before the first frame update
    void Start()
    {
        Button.text = "OFF";
        PushCount.text = "0";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void aboba()
    { 
        if (CUBE.gameObject.activeSelf)
        {
            CUBE.gameObject.SetActive(false);
            Button.text = "ON";
            k++;
            PushCount.text = k.ToString();
        }
        else
        {
            CUBE.gameObject.SetActive(true);
            Button.text = "OFF";
            k++;
            PushCount.text = k.ToString();
        }
            
    }

}
