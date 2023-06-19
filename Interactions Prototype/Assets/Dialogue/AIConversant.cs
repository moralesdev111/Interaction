using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Dialogue
{
public class AIConversant : MonoBehaviour
{    
[SerializeField] Dialogue dialogue = null;
[SerializeField] Transform playerController;

private void Update() 
{
   float distance = Vector3.Distance(transform.position, playerController.position);
    if (distance <= 7f)
      {           
        if(Input.GetKeyDown(KeyCode.E))
        {        
           playerController.GetComponent<PlayerConversant>().StartDialogue(dialogue);
        }
      }
  
    }
  }
}




