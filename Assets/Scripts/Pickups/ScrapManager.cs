using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapManager : MonoBehaviour {

    private static ScrapManager instance;

    public static ScrapManager Instance
    {
        get
        {
            if (instance == null)
            {
                var gameObject = new GameObject(name: typeof(ScrapManager).Name);
                instance = gameObject.AddComponent<ScrapManager>();
                DontDestroyOnLoad(gameObject);
            }

            return instance;
        }
    }

    public int ScrapCount { get; set; }
}
