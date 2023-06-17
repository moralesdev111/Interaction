using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOnOff : MonoBehaviour
{
    [SerializeField ]GameObject UI;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(UI.activeInHierarchy == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
        }

        
        else return;
    }
}
