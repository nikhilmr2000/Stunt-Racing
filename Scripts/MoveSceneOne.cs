using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveSceneOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){

    }

    void PlayNext(){
    	SceneManager.LoadScene(1);    
    }

    void PlayAgain(){
    	Invoke("PlayNext",2f);

    }

    void Update(){
    	PlayAgain();
    }

 }
