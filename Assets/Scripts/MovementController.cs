using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour
{
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        guiObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
    }


    public GameObject guiObject;
    public string levelToLoad;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Door")
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