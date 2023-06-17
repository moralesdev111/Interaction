using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Dialogue
{
public class AIConversant : MonoBehaviour
{
    
[SerializeField] Dialogue dialogue = null;
   void OnTriggerEnter(Collider other) 
 {
    if(other.gameObject.tag == "Player")
    {
        
        if(Input.GetKeyDown(KeyCode.E))
        {

            GetComponent<PlayerConversant>().StartDialogue(dialogue);

        }
        }
 } 
 }

}

