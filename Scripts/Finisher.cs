using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finisher : MonoBehaviour
{
    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider collision){
    	if(collision.gameObject.tag=="Player"){
    		PlayFirst();
    	}
    }

    void LoadAgain(){
    	SceneManager.LoadScene(7);
    }

    void PlayFirst(){
    	Invoke("LoadAgain",1f);
    }

    
}
