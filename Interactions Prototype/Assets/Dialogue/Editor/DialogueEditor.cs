using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Callbacks;
using UnityEditor;

namespace RPG.Dialogue.Editor
{    
    public class DialogueEditor : EditorWindow 
    {
    Dialogue selectedDialogue = null;

    [MenuItem("Window/Dialogue Editor")]
    public static void ShowEditorWindow()
    {
        GetWindow(typeof(DialogueEditor), false, "Dialogue Editor");
    }
    
    [OnOpenAsset(1)]
    public static bool OnOpenAsset(int instanceID, int line)
    {
        Dialogue dialogue = EditorUtility.InstanceIDToObject(instanceID) as Dialogue;
        if (dialogue != null)
        {
            ShowEditorWindow();
            return true;
        }
        
        return false;
    }
    void OnEnable() 
    {
    Selection.selectionChanged += OnSelectionChanged;

    }
    
    void OnSelectionChanged() 
    {
        Dialogue newDialogue = Selection.activeObject as Dialogue;
        if (newDialogue != null)
        {
            selectedDialogue = newDialogue;
            Repaint();
        }
    }

    void OnGUI() 
    {
        if (selectedDialogue == null)
    {
        EditorGUILayout.LabelField("No Dialogue Selected");
    }
    else
    {
        foreach (DialogueNode node in selectedDialogue.GetAllNodes())
        {
            EditorGUILayout.LabelField(node.text);

        }
    }          


{
    
}

                   
    }
    }
}





