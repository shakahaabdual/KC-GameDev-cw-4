using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gamemanger : MonoBehaviour
{
    int scorn  = 0;
    
    int increment = 1;

    public Text text1;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per framec
    void Update()
    {

    }

    public void increse()
    {
        scorn += increment;
        text1.text = scorn.ToString();
    }

    public void Store()
    {
        if (scorn > 5)
        {
            increment++;
            scorn -= 5;
            text1.text = scorn.ToString();
        }
        else
        {
            print("you don,t have enough score!");
        }
    }
}
 