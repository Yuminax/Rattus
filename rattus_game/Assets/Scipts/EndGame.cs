using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] GameObject btnEnd;

    // Start is called before the first frame update
    void Start()
    {
        btnEnd.SetActive(false);
        StartCoroutine(MyCoroutine(time));
    }

    IEnumerator MyCoroutine(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        Debug.Log("End");
        //SceneManager.LoadScene("MainMenu");
        btnEnd.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
