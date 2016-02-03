using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    public int sceneLevel;

    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("OutsideScene", LoadSceneMode.Single);

    }
    public void onClick()
    {
        SceneManager.LoadScene("OutsideScene", LoadSceneMode.Single);
    }
}
