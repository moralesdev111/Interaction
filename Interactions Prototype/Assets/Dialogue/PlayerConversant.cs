using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RPG.Dialogue
{
    public class PlayerConversant : MonoBehaviour
    {
        [SerializeField] string playerName;

        Dialogue currentDialogue;
        DialogueNode currentNode = null;
        AIConversant currentConversant = null;
        bool isChoosing = false;

        public event Action onConversationUpdated;

        public void StartDialogue(AIConversant newConversant, Dialogue newDialogue)
        {
            currentConversant = newConversant;
            currentDialogue = newDialogue;
            currentNode = currentDialogue.GetRootNode();
            
            onConversationUpdated();
        }

        public void Quit()
        {
            currentDialogue = null;
            
            currentNode = null;
            isChoosing = false;
            currentConversant = null;
            onConversationUpdated();
        }

        public bool IsActive()
        {
            return currentDialogue != null;
        }

        public bool IsChoosing()
        {
            return isChoosing;
        }

        public string GetText()
        {
            if (currentNode == null)
            {
                return "";
            }

            return currentNode.GetText();
        }

        public string GetCurrentConversantName()
        {
            if (isChoosing)
            {
                return playerName;
            }
            else
            {
                return currentConversant.GetName();
            }
        }

        public IEnumerable<DialogueNode> GetChoices()
        {
            return currentDialogue.GetPlayerChilren(currentNode);
        }

        public void SelectChoice(DialogueNode chosenNode)
        {
            currentNode = chosenNode;
            
            isChoosing = false;
            Next();
        }
    
        public void Next()
        {
            
            int numPlayerResponses = currentDialogue.GetPlayerChilren(currentNode).Count();
            if (numPlayerResponses > 0)
            {
                isChoosing = true;
                
                onConversationUpdated();
                return;
            }

            DialogueNode[] children = currentDialogue.GetAIChildren(currentNode).ToArray();
            if(children.Length > 0)
            {
                
                currentNode = children[UnityEngine.Random.Range(0, children.Count())];
                
                onConversationUpdated();
            }
            else
            {
                Quit();
            }
        }

        public bool HasNext()
        {
            return currentDialogue.GetAllChildren(currentNode).Count() > 0;
        }

        
    }
}