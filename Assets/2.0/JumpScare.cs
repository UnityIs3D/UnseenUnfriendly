using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject canvasStuff;
    public AudioSource chainSawCutting;

    // Start is called before the first frame update
    private void Start()
    {
        canvasStuff.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(DelayRetryMenu());
    }



    private IEnumerator DelayRetryMenu()
    {
        yield return new WaitForSeconds(5f);
        canvasStuff.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 
        chainSawCutting.Stop();
    }
}
