using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ByBirth : MonoBehaviour
{
    // Start is called before the first frame update
	void Start(){
	}

	void Error(){
		if(transform.position.y<565f){
			PlayNextScene();
		}
	}

	void PlayScene(){
		SceneManager.LoadScene(6);
	}

	void PlayNextScene(){
		Invoke("PlayScene",0.4f);
	}

	void Update(){
		Error();

	}
}
