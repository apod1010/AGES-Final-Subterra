using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScrapManager.Instance.ScrapCount++;
            Destroy(this.gameObject);
        }
    }
}
