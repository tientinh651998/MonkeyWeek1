using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Award : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        SceneManager.LoadScene("Achievements");
    }

    public void Click()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("Achievements");
    }
}
