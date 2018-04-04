using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrapText : MonoBehaviour {

    private Text labelText;

    private void Start()
    {
        labelText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        labelText.text = ScrapManager.Instance.ScrapCount.ToString();
    }
}
