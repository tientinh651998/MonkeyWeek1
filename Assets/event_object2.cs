using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class event_object2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Object 2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        Debug.Log("Abc");
        SceneManager.LoadScene("MainScene");
    }
}
