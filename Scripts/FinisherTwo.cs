using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinisherTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collision){
    	if(collision.gameObject.tag=="Player"){
    		PlayFirst();
    	}
    }

    void LoadAgain(){
    	SceneManager.LoadScene(8);
    }

    void PlayFirst(){
    	Invoke("LoadAgain",1f);
    }
}
