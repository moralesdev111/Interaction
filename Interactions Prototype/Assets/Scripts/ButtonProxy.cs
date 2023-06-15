using System;

using UnityEngine;

using UnityEngine.UI;



public class ButtonProxy : MonoBehaviour

{

    [SerializeField] Button nextButton;
    

    private KeyCode key;

    private void Awake()

    {

        nextButton = GetComponent<Button>();

    }



    public void SetKey(KeyCode keyCode)

    {

        key = keyCode;

    }



    private void Update()

    {

        if (key < 0) return;

        if (Input.GetKeyDown("return"))

        {

            nextButton.onClick?.Invoke();

        }
        if (Input.GetKeyDown("escape"))
        {


        }


    }

}    