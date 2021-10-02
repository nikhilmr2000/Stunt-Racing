using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    Quaternion startingPos;
    void Start()
    {
        startingPos=transform.rotation;
    }

    // Update is called once per frame

    void Updater(){
    	if(transform.localEulerAngles.z==-180 || transform.localEulerAngles.z==-90 || transform.localEulerAngles.z==90 || transform.localEulerAngles.z==180 || transform.localEulerAngles.x==-180){
    		PlayNextLevel();
    	}
    }

    void PlayAgain(){
    	SceneManager.LoadScene(5);
    }

    void PlayNextLevel(){
    	Invoke("PlayAgain",1f);
    }
    void Update()
    {
        Updater();
    }
}
