using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOnOff : MonoBehaviour
{
    [SerializeField] GameObject UI;    
    
    void Update()
    {
        MouseOnOffControl();
    }

    void MouseOnOffControl()
    {
        if(!UI.gameObject.activeSelf)
        {            
            Cursor.visible = false;
        }

        
        else 
        {
            Cursor.visible = true;
        }
    }
}
