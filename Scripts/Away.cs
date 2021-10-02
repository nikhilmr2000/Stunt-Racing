using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Away : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision other){
    	if(other.gameObject.tag=="Player"){
    		PlayAgain();
    	}

    }

    void PlayAfter(){
    	SceneManager.LoadScene(5);
    }

    void PlayAgain(){
    	Invoke("PlayAfter",2f);
    }
    void Update()
    {
        
    }
}
