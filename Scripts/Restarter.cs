using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Maker(){
    	SceneManager.LoadScene(3);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
