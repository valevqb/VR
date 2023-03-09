using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject obj;
    
    public void Toggle() 
    {
        if (obj.activeSelf == false)
        {
            obj.SetActive(true);
        }
        else 
        {
            obj.SetActive(false);
        }
    }
}
