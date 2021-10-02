using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackHome : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per 
    public void Clicker(){
    	SceneManager.LoadScene(5);
    }

    public void Clicking(){
    	Invoke("Clicker",1f);
    }

}
