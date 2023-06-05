using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Callbacks;
using UnityEditor;

namespace RPG.Dialogue.Editor
{
    
    public class DialogueEditor : EditorWindow 
    {
    [MenuItem("Window/Dialogue Editor")]
    public static void ShowEditorWindow()
    {

        GetWindow(typeof(DialogueEditor), false, "Dialogue Editor");
    }
    
    [OnOpenAssetAttribute(1)]
    public static bool OnOpenAsset(int instanceID, int line)
    {
        Debug.Log("OpenDialogue");
        return false;
    }
    }
}





