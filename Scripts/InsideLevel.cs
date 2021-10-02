using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InsideLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Speech(){
    	SceneManager.LoadScene(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
