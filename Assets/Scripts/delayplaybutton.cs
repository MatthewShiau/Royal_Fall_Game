using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
       public GameObject Button;


       void Start()
       {
          Button.SetActive(true);
          Invoke("buttonDelay",10);
       }

    private void buttonDelay()
       { 
        Button.SetActive(false);
       }
       
}
