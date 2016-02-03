using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	bool checkLoad = false;
	void OnTriggerEnter(Collider other) {
		onClick ();
	}

	public void onClick() {
		if (checkLoad == false) {
			SceneManager.LoadSceneAsync ((SceneManager.GetActiveScene ().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
			checkLoad = true;
		}
    }
}
