using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FiestLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Starter(){
    	SceneManager.LoadScene(3);
    }

    void Starting(){
    	Invoke("Starter",4.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Starting();
    }
}
