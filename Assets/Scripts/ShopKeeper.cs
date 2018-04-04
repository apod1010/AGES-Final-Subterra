using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : MonoBehaviour
{

    public GameObject guiObject;

    private void Start()
    {
        guiObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetButtonDown("Use") && ScrapManager.Instance.ScrapCount > 0)
            {
                ScrapManager.Instance.ScrapCount--;
            }
        }
    }
    private void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
