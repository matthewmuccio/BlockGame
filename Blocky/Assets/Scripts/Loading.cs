using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

// Loading controls the loading scene between scenes (like the Menu scene and the Stage scene).
// Whenever the Loading scene is initalized, a coroutine begins loading the next scene
// after waiting a split second.
public class Loading : MonoBehaviour
{
    // Use this for initialization.
    void Start()
    {
        // Starts a coroutine with an IEnumerator parameter that waits one.
        StartCoroutine(loading());
        // Then loads the Stage scene using the SceneManager, which manages scences at runtime.
        SceneManager.LoadScene("Stage");
    }

    // Returns an IEnumerator that creates a yield instruction to wait for a brief second in scaled time.
    IEnumerator loading()
    {
        yield return new WaitForSeconds(0F);
    }
}