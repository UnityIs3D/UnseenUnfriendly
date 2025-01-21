using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UglyMenu : MonoBehaviour
{

    public GameObject keybinds;
    public GameObject instructions;
    public GameObject Credits;


    private void Start()
    {
        keybinds.SetActive(false);
        instructions.SetActive(false);
        Credits.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    public void TurnONTheFuckingShit()
    {
        keybinds.SetActive(true);
        instructions.SetActive(true);
        Credits.SetActive(true);
    }
}
