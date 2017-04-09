using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Loading : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        StartCoroutine(loading());
        SceneManager.LoadScene(2);
    }

    IEnumerator loading()
    {
        yield return new WaitForSeconds(1F);
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
