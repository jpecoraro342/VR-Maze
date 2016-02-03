using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    public int sceneLevel;

	int numberOfScenes;

	void OnTriggerEnter(Collider other) {
		SceneManager.LoadSceneAsync((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCount);
	}

	public void onClick() {
		SceneManager.LoadSceneAsync((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCount);
    }
}
