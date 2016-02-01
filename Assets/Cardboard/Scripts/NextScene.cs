using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("OutsideScene", LoadSceneMode.Single);

    }
}
