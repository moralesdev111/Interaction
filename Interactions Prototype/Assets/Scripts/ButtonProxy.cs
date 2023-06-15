using System;

using UnityEngine;

using UnityEngine.UI;



public class ButtonProxy : MonoBehaviour

{

    private Button button;

    private KeyCode key;

    private void Awake()

    {

        button = GetComponent<Button>();

    }



    public void SetKey(KeyCode keyCode)

    {

        key = keyCode;

    }



    private void Update()

    {

        

        if (Input.GetKeyDown("return"))

        {

            button.onClick?.Invoke();

        }

    }

}    