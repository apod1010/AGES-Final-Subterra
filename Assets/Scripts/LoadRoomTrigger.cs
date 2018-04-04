using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRoomTrigger : MonoBehaviour
{

    public GameObject guiObject;
    public string levelToLoad;

    private void Start()
    {
        guiObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
    private void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
