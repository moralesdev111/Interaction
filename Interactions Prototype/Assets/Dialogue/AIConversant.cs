using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Dialogue
{
public class AIConversant : MonoBehaviour
{
    
[SerializeField] Dialogue dialogue = null;
[SerializeField] GameObject playerController;





     void OnTriggerStay(Collider other) 
   {
    if(other.gameObject.tag == "Player")
    {
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(dialogue == null)

           playerController.GetComponent<PlayerConversant>().StartDialogue(dialogue);

        }
        }
   }
 
    
  
 }

}

