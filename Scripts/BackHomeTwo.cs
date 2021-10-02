using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackHomeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    public void Clicker(){
    	SceneManager.LoadScene(6);
    }

    public void Clicking(){
    	Invoke("Clicker",1f);
    }

}
