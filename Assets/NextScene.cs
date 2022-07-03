using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    public bool IsTransition;

    public float TimerToTransit;

    public string scene;

    public GameObject Fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTransition == true)
        {
            TimerToTransit -= Time.deltaTime;

            if (TimerToTransit <= 1.4f)
            {
                Fade.SetActive(true);
            }

            if (TimerToTransit <= 0)
            {
                SceneManager.LoadScene(scene);
            }
        }
    }

    public void GoNextScene()
    {
        Fade.SetActive(true);
        StartCoroutine(Waiter());
    }

    IEnumerator Waiter()
    {

        yield return new WaitForSeconds(1.6f);
        SceneManager.LoadScene(scene);
    }
}
