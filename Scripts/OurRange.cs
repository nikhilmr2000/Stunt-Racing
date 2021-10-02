using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OurRange : MonoBehaviour
{
	Vector3 startingPos;
	void Start(){
		startingPos=transform.position;
	}

	void Error(){
		if(transform.position.y<0){
			PlayNextScene();
		}
	}

	void PlayScene(){
		SceneManager.LoadScene(5);
	}

	void PlayNextScene(){
		Invoke("PlayScene",1f);
	}

	void Update(){
		Error();

	}
}